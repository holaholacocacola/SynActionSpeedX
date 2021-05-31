using Mutagen.Bethesda;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Synthesis;
using Noggog;
using System;
using System.Collections.Generic;

namespace ActionSpeedX
{
    public class SpellPatcher
    {
        static ModKey Adamant   = ModKey.FromNameAndExtension("Adamant.esp");
        static ModKey Vokrii    = ModKey.FromNameAndExtension("Vokrii - Minimalistic Perks of Skyrim.esp");
        static ModKey Ordinator = ModKey.FromNameAndExtension("Ordinator - Perks Of Skyrim.esp");
        
        private readonly IPatcherState<ISkyrimMod, ISkyrimModGetter> state;
        private readonly ActionSpeedX.Settings settings; // in memory rep of settings.json
        public SpellPatcher(IPatcherState<ISkyrimMod, ISkyrimModGetter> state, ActionSpeedX.Settings settings)
        {
            this.state = state;
            this.settings = settings;
        }


        public bool PatchSpells()
        {
            // check all supported mods because of abominations like vokriinator black
            bool success = true;

            if (state.LoadOrder.ContainsKey(Adamant))
            {
                Console.WriteLine("Adamant will be patched.");
                success = RebalancePerks(ActionSpeedX.FormKeys.AdamantSpells.StaminaSpells, ActionSpeedX.FormKeys.AdamantSpells.MoveSpells);
                if (!success) Console.WriteLine("Failed to patch adamant");
            }

            if (state.LoadOrder.ContainsKey(Ordinator))
            {
                Console.WriteLine("Ordinator will be patched.");
                success = RebalancePerks(ActionSpeedX.FormKeys.OrdinatorSpells.StaminaSpells, ActionSpeedX.FormKeys.OrdinatorSpells.MoveSpells);
                if (!success) Console.WriteLine("Failed to patch ordinator");
            }

            if (state.LoadOrder.ContainsKey(Vokrii))
            {
                Console.WriteLine("Vokrii will be patched.");
                success = RebalancePerks(ActionSpeedX.FormKeys.VokriiSpells.StaminaSpells, ActionSpeedX.FormKeys.VokriiSpells.MoveSpells);
                if (!success) Console.WriteLine("Failed to patch vokrii");
            }
            return success;
        }

        private bool RebalancePerks(List<ActionSpeedX.FormKeys.SpellEffectModifier> staminaSpells, List<ActionSpeedX.FormKeys.SpellEffectModifier> speedSpells)
        {
            bool hasError = false;
            if (this.settings.StaminaRegen)
            {
                foreach (var stamModifier in staminaSpells)
                {
                    if (!AdjustEffect(stamModifier)) hasError = true;
                }
            }

            if (this.settings.MoveSpeed)
            {
                foreach (var speedModifier in speedSpells)
                {
                    if (!AdjustEffect(speedModifier)) hasError = true;
                }
            }

            return !hasError;
        }

        private bool AdjustEffect(ActionSpeedX.FormKeys.SpellEffectModifier spellToModify)
        {
            if (!this.state.LinkCache.TryResolve<ISpellGetter>(spellToModify.formLink.FormKey, out var spell))
            {
                Console.Out.WriteLine($"Could not resolve form key for: {spellToModify.editorId}");
                return false;
            }
            var modifiedSpell = spell.DeepCopy();
            var effect = modifiedSpell.Effects[spellToModify.effectSlot];
            if (effect.Data == null)
            {
                Console.Out.WriteLine($"{spellToModify.editorId} has no effects.");
                return false;
            }

            effect.Data.Magnitude = spellToModify.magnitude;
            state.PatchMod.Spells.Add(modifiedSpell);
            return true;
        }
    }
}