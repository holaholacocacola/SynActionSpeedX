using Mutagen.Bethesda;
using Mutagen.Bethesda.FormKeys.SkyrimSE;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Synthesis;
using Newtonsoft.Json.Linq;
using Noggog;
using System;
using System.Collections.Generic;
using System.IO;

namespace ActionSpeedX
{
    public class NpcPatcher
    {
        private IPatcherState<ISkyrimMod, ISkyrimModGetter> state;
        private ActionSpeedX.Settings settings; // in memory rep of settings.json
        private HashSet<FormLink<IRaceGetter>> racesToPatch; // contains valid races to add perks too.
        private List<FormKey> perksToAdd; // Contains form ids of perks to add to every npc.

        public NpcPatcher(IPatcherState<ISkyrimMod, ISkyrimModGetter> state, ActionSpeedX.Settings settings)
        {
            this.state = state;
            this.settings = settings;
            this.racesToPatch = loadRaces();
            this.perksToAdd = new List<FormKey>();
            
            if (this.settings.AttackSpeed) perksToAdd.AddRange(ActionSpeedX.FormKeys.Perks.AttackSpeed);

            if (this.settings.MagickaRegen) perksToAdd.AddRange(ActionSpeedX.FormKeys.Perks.MagickaRegen);

            if (this.settings.MoveSpeed) perksToAdd.AddRange(ActionSpeedX.FormKeys.Perks.MoveSpeed);

            if (this.settings.RangedAttack) perksToAdd.AddRange(ActionSpeedX.FormKeys.Perks.RangedSpeed);

            if (this.settings.PowerAttacks) perksToAdd.AddRange(ActionSpeedX.FormKeys.Perks.PowerAttacks);

            if (this.settings.StaminaRegen) perksToAdd.AddRange(ActionSpeedX.FormKeys.Perks.StaminaRegen);

            if (this.settings.SpellCosts) perksToAdd.AddRange(ActionSpeedX.FormKeys.Perks.SpellCosts);
        }

        private HashSet<FormLink<IRaceGetter>> loadRaces()
        {
            var parsed = new HashSet<FormLink<IRaceGetter>>(settings.DefaultRaces);
            if (this.settings.Creatures) parsed.UnionWith(settings.CreatureRaces);
            return parsed;
        }

        public void PatchNpcs()
        {
            /*
             * 1. Loop over all npcs.
             * 2. Verify it is not a ghost, an inherited template, and has a valid race
             * 3. Check if it has a match with a races
             * 4. Add perks based on settings.json
             * 
             */

            foreach (var npc in this.state.LoadOrder.PriorityOrder.WinningOverrides<INpcGetter>())
            {
                if (npc.Configuration.TemplateFlags.HasFlag(NpcConfiguration.TemplateFlag.SpellList) || npc.EditorID == null) continue; // Perks are inherited from a template
                if (npc.Keywords != null && npc.Keywords.Contains(Skyrim.Keyword.ActorTypeGhost)) continue; // Ghost shouldnt be affected by armor
                if (!this.racesToPatch.Contains(npc.Race)) continue;

                var npcCopy = this.state.PatchMod.Npcs.GetOrAddAsOverride(npc);
                if (npcCopy.Perks == null) npcCopy.Perks = new ExtendedList<PerkPlacement>();
                foreach (var perk in this.perksToAdd)
                {
                    PerkPlacement p = new PerkPlacement { Rank = 1, Perk = perk };
                    npcCopy.Perks.Add(p);
                }

                if (npc.EditorID == "Player" && this.settings.Racials) 
                {
                    // a quest runs after racemenu that will sift and apply the correct racial perk. This perk is removed after.
                    PerkPlacement p = new PerkPlacement { Rank = 1, Perk = ActionSpeedX.FormKeys.Perks.ASX_DummyPerk };
                    npcCopy.Perks.Add(p);                  
                    continue;
                }

                if (this.settings.Racials && ActionSpeedX.FormKeys.Perks.RacialPerks.TryGetValue(npc.Race.FormKey, out var racialPerk))
                {
                    PerkPlacement p = new PerkPlacement { Rank = 1, Perk = racialPerk };
                    npcCopy.Perks.Add(p);   
                }

                if (this.settings.Factions && npc.Factions != null)
                {
                    foreach (var faction in npc.Factions)
                    {
                        if (ActionSpeedX.FormKeys.Perks.FactionPerks.TryGetValue(faction.Faction.FormKey, out var factionPerk))
                        {
                            PerkPlacement p = new PerkPlacement { Rank = 1, Perk = factionPerk };
                            npcCopy.Perks.Add(p);
                        }
                    }   
                }
            }
        }
    }
}