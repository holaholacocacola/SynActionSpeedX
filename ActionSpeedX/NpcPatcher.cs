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

        private IPatcherState<ISkyrimMod, ISkyrimModGetter> state;
        private ActionSpeedX.Settings settings; // in memory rep of settings.json
        private HashSet<string> racesToPatch; // contains valid races to add perks too.
        
        private List<FormLink<IPerkGetter>> perksToAdd; // Contains form ids of perks to add to every npc.

        public NpcPatcher(IPatcherState<ISkyrimMod, ISkyrimModGetter> state, ActionSpeedX.Settings settings)
        {
            this.state        = state;
            this.settings     = settings;
            this.racesToPatch = loadRaces();
            this.perksToAdd   = new();
            
            if (this.settings.AttackSpeed) perksToAdd.AddRange(ActionSpeedX.FormKeys.Perks.AttackSpeed);

            if (this.settings.MagickaRegen) perksToAdd.AddRange(ActionSpeedX.FormKeys.Perks.MagickaRegen);

            if (this.settings.MoveSpeed) perksToAdd.AddRange(ActionSpeedX.FormKeys.Perks.MoveSpeed);

            if (this.settings.RangedAttack) perksToAdd.AddRange(ActionSpeedX.FormKeys.Perks.RangedSpeed);

            if (this.settings.PowerAttacks) perksToAdd.AddRange(ActionSpeedX.FormKeys.Perks.PowerAttacks);

            if (this.settings.StaminaRegen) perksToAdd.AddRange(ActionSpeedX.FormKeys.Perks.StaminaRegen);

            if (this.settings.SpellCosts) perksToAdd.AddRange(ActionSpeedX.FormKeys.Perks.SpellCosts);
        }

        private HashSet<string> loadRaces()
        {
            string file = Path.Combine(this.state.ExtraSettingsDataPath, RACES_FILE); // already validated in callee
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
             * 
             */

            foreach (var npc in this.state.LoadOrder.PriorityOrder.WinningOverrides<INpcGetter>())
            {
                try 
                { 
                    if (npc.Configuration.TemplateFlags.HasFlag(NpcConfiguration.TemplateFlag.SpellList) || npc.EditorID == null) continue; // Perks are inherited from a template
                    if (npc.Keywords != null && npc.Keywords.Contains(Skyrim.Keyword.ActorTypeGhost)) continue; // Ghost shouldnt be affected by armor
                    if (!npc.Race.TryResolve(state.LinkCache, out var race) || race.EditorID == null || !this.racesToPatch.Contains(race.EditorID)) continue;

                    var npcCopy = this.state.PatchMod.Npcs.GetOrAddAsOverride(npc);
                    if (npcCopy.Perks == null) npcCopy.Perks = new ExtendedList<PerkPlacement>();
                    foreach (var perk in this.perksToAdd)
                    {
                        PerkPlacement p = new PerkPlacement { Rank = 1, Perk = perk.FormKey.AsLink<IPerkGetter>() };
                        npcCopy.Perks.Add(p);
                    }

                    if (npc.EditorID == "Player" && this.settings.Racials)
                    {
                        // a quest runs after racemenu that will sift and apply the correct racial perk. This perk is removed after.
                        PerkPlacement p = new PerkPlacement { Rank = 1, Perk = FormKeys.Perks.ASX_DummyPerk.FormKey.AsLink<IPerkGetter>() };
                        npcCopy.Perks.Add(p);
                        continue;
                    }

                    if (this.settings.Racials && ActionSpeedX.FormKeys.Perks.RacialPerks.ContainsKey(race.EditorID))
                    {
                        PerkPlacement p = new PerkPlacement { Rank = 1, Perk = FormKeys.Perks.RacialPerks[race.EditorID].FormKey.AsLink<IPerkGetter>() };
                        npcCopy.Perks.Add(p);
                    }

                    if (this.settings.Factions && npc.Factions != null)
                    {
                        foreach (var faction in npc.Factions)
                        {
                            if (faction.Faction.TryResolve(this.state.LinkCache, out var wtf) && wtf.EditorID != null && ActionSpeedX.FormKeys.Perks.FactionPerks.ContainsKey(wtf.EditorID))
                            {
                                PerkPlacement p = new PerkPlacement { Rank = 1, Perk = FormKeys.Perks.FactionPerks[wtf.EditorID].FormKey.AsLink<IPerkGetter>() };
                                npcCopy.Perks.Add(p);
                            }
                        }
                    }
                } catch (Exception e) 
                {
                    throw RecordException.Create("Error processing npc record", npc, e);
                }
            }
        }
    }
}