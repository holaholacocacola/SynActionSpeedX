using Mutagen.Bethesda;
using Mutagen.Bethesda.FormKeys.SkyrimSE;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Plugins.Exceptions;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Synthesis;
using Newtonsoft.Json.Linq;
using Noggog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace ActionSpeedX
{
    public class NpcPatcher
    {
        const string RACES_FILE = "races.json";

        private readonly IPatcherState<ISkyrimMod, ISkyrimModGetter> _state;
        private readonly Settings _settings; // in memory rep of settings.json
        private readonly HashSet<string> _validRaces; // contains valid races to add perks too.
        
        private readonly List<FormLink<IPerkGetter>> _perksToDistribute; // Contains form ids of perks to add to every npc.
        private readonly FormKeys.PerkBlah _perkBlah;

        public NpcPatcher(IPatcherState<ISkyrimMod, ISkyrimModGetter> state, ActionSpeedX.Settings settings)
        {
            this._state               = state;
            this._settings            = settings;
            this._validRaces          = LoadRaces();
            this._perksToDistribute   = new();
            this._perkBlah            = FormKeys.vanillaPerkBlah;

            /* ASX-Perf-Refactor. Spells are added on equip. We only need to attach Power Attack and spell cost perks as those use perk entry points.
            if (this.settings.AttackSpeed) perksToAdd.AddRange(ActionSpeedX.FormKeys.Perks.AttackSpeed);
            if (this.settings.MagickaRegen) perksToAdd.AddRange(ActionSpeedX.FormKeys.Perks.MagickaRegen);
            if (this.settings.MoveSpeed) perksToAdd.AddRange(ActionSpeedX.FormKeys.Perks.MoveSpeed);
            if (this.settings.RangedAttack) perksToAdd.AddRange(ActionSpeedX.FormKeys.Perks.RangedSpeed);
            if (this.settings.StaminaRegen) perksToAdd.AddRange(ActionSpeedX.FormKeys.Perks.StaminaRegen);
            */
            if (this._settings.PowerAttacks) _perksToDistribute.AddRange(FormKeys.ActionSpeedXPerks.PowerAttacks);
            if (this._settings.SpellCosts) _perksToDistribute.AddRange(FormKeys.ActionSpeedXPerks.SpellCosts);
        }

        private HashSet<string> LoadRaces()
        {
            string file = Path.Combine(this._state.ExtraSettingsDataPath, RACES_FILE); // already validated in callee
            var races   = JObject.Parse(File.ReadAllText(file));
            
            Dictionary<string, List<string>>? availableRaces = races.ToObject<Dictionary<string, List<string>>>();
            if (availableRaces == null)
            {
                throw new Exception("Could not parse armor materials file");
            }
            HashSet<string> parsed = new HashSet<string>(availableRaces["default"]); // this could throw
            //if (this.settings.Creatures) parsed.UnionWith(availableRaces["creatures"]); // disable creatures for now
            return parsed;
        }

        public void PatchNpcs()
        {
            /*
             * 1. Loop over all npcs.
             * 2. Verify it is not a ghost, an inherited template, and has a valid race
             * 3. Check if it has a match with a race in races.json
             * 4. Add perks based on settings.json
             * 5. Check npcs class and distribute novice perk if applicable
             * 
             */

            foreach (var npc in this._state.LoadOrder.PriorityOrder.WinningOverrides<INpcGetter>())
            {
                try 
                { 
                    if (npc.Configuration.TemplateFlags.HasFlag(NpcConfiguration.TemplateFlag.SpellList) || npc.EditorID == null) continue; // Perks are inherited from a template
                    if (npc.Keywords != null && npc.Keywords.Contains(Skyrim.Keyword.ActorTypeGhost)) continue; // Ghost shouldnt be affected by armor
                    if (!npc.Race.TryResolve(_state.LinkCache, out var race) || race.EditorID == null || !this._validRaces.Contains(race.EditorID)) continue;

                    var npcCopy = this._state.PatchMod.Npcs.GetOrAddAsOverride(npc);
                    if (npcCopy.Perks == null) npcCopy.Perks = new ExtendedList<PerkPlacement>();
                    foreach (var perk in this._perksToDistribute)
                    {
                        PerkPlacement p = new PerkPlacement { Rank = 1, Perk = perk.FormKey.AsLink<IPerkGetter>() };
                        npcCopy.Perks.Add(p);
                    }

                    if (npc.EditorID == "Player" && this._settings.Racials)
                    {
                        // a quest runs after racemenu that will sift and apply the correct racial perk. This perk is removed after. 
                        PerkPlacement p = new PerkPlacement { Rank = 1, Perk = FormKeys.ActionSpeedXPerks.ASX_DummyPerk.FormKey.AsLink<IPerkGetter>() };
                        npcCopy.Perks.Add(p);
                        continue;
                    }

                    if (this._settings.Racials && FormKeys.ActionSpeedXPerks.RacialPerks.ContainsKey(race.EditorID))
                    {
                        PerkPlacement p = new PerkPlacement { Rank = 1, Perk = FormKeys.ActionSpeedXPerks.RacialPerks[race.EditorID].FormKey.AsLink<IPerkGetter>() };
                        npcCopy.Perks.Add(p);
                    }

                    if (this._settings.Factions && npc.Factions != null)
                    {
                        foreach (var faction in npc.Factions)
                        {
                            if (faction.Faction.TryResolve(this._state.LinkCache, out var wtf) && wtf.EditorID != null && FormKeys.ActionSpeedXPerks.FactionPerks.ContainsKey(wtf.EditorID))
                            {
                                PerkPlacement p = new PerkPlacement { Rank = 1, Perk = FormKeys.ActionSpeedXPerks.FactionPerks[wtf.EditorID].FormKey.AsLink<IPerkGetter>() };
                                npcCopy.Perks.Add(p);
                                
                            }
                        }
                    }

                    //check skill weights. This will distribute passive perks to npcs that can actually make use of them. Map of skillweights -> perk
                    if (npc.Class != null && npc.Class.TryResolve(this._state.LinkCache, out var npcClass))
                    {
                        if (this._settings.StaminaRegen) DistributeClassPerks(npcCopy, this._perkBlah.StaminaSkillPerks, npcClass);
                        if (this._settings.MagickaRegen) DistributeClassPerks(npcCopy, this._perkBlah.MagickaSkillPerks, npcClass);
                        if (this._settings.MoveSpeed)    DistributeClassPerks(npcCopy, this._perkBlah.SpeedSkillPerks, npcClass);
                        if (this._settings.AttackSpeed)  DistributeClassPerks(npcCopy, this._perkBlah.AttackSpeedSkillPerks, npcClass);
                        if (this._settings.RangedAttack) DistributeClassPerks(npcCopy, this._perkBlah.RangedAttackSkillPerks, npcClass);

                    }

                } catch (Exception e) 
                {
                    throw RecordException.Create("Error processing npc record", npc, e);
                }
            }

            //add player check here

        }

        private void DistributeClassPerks(Npc npcCopy, Dictionary<Skill, FormLink<IPerkGetter>> perksToAdd, IClassGetter npcClass)
        {
            if (npcCopy.Perks == null) npcCopy.Perks = new ExtendedList<PerkPlacement>(); // This will never happen
            foreach (var entry in perksToAdd)
            {
                if (npcClass.SkillWeights.ContainsKey(entry.Key) && npcClass.SkillWeights[entry.Key] > 0)
                {
                    
                    PerkPlacement p = new PerkPlacement { Rank = 1, Perk = entry.Value.FormKey.AsLink<IPerkGetter>() };
                    if(!npcCopy.Perks.Contains(p) ) npcCopy.Perks.Add(p); // List :(
                }
            }
        }
    }
}