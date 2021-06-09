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
       
        private readonly IPatcherState<ISkyrimMod, ISkyrimModGetter> _state;
        private readonly Settings _settings; // in memory rep of settings.json
        public SpellPatcher(IPatcherState<ISkyrimMod, ISkyrimModGetter> state, Settings settings)
        {
            this._state = state;
            this._settings = settings;
        }


        public bool PatchSpells()
        {
            // check all supported mods because of abominations like vokriinator black
            bool success = true;

            if (this._settings.GetPatchOption() == PatchOption.Adamant)
            {
                Console.WriteLine("Adamant will be patched.");
                success = RebalancePerks(FormKeys.AdamantSpells.StaminaSpells, FormKeys.AdamantSpells.MoveSpells);
                if (!success) Console.WriteLine("Failed to patch adamant");
            }

            else if (this._settings.GetPatchOption() == PatchOption.Ordinator)
            {
                Console.WriteLine("Ordinator will be patched.");
                success = RebalancePerks(FormKeys.OrdinatorSpells.StaminaSpells, FormKeys.OrdinatorSpells.MoveSpells);
                if (!success) Console.WriteLine("Failed to patch ordinator");
            }

            else if (this._settings.GetPatchOption() == PatchOption.Vokrii)
            {
                Console.WriteLine("Vokrii will be patched.");
                success = RebalancePerks(FormKeys.VokriiSpells.StaminaSpells, FormKeys.VokriiSpells.MoveSpells);
                if (!success) Console.WriteLine("Failed to patch vokrii");
            }
            return success;
        }

        private bool RebalancePerks(List<FormKeys.SpellEffectModifier> staminaSpells, List<FormKeys.SpellEffectModifier> speedSpells)
        {
            bool hasError = false;
            if (this._settings.StaminaRegen)
            {
                foreach (var stamModifier in staminaSpells)
                {
                    if (!AdjustEffect(stamModifier)) hasError = true;
                }
            }

            if (this._settings.MoveSpeed)
            {
                foreach (var speedModifier in speedSpells)
                {
                    if (!AdjustEffect(speedModifier)) hasError = true;
                }
            }

            return !hasError;
        }

        private bool AdjustEffect(FormKeys.SpellEffectModifier spellToModify)
        {
            if (!this._state.LinkCache.TryResolve<ISpellGetter>(spellToModify.SpellForm.FormKey, out var spell))
            {
                Console.Out.WriteLine($"Could not resolve form key for: {spellToModify.EditorId}");
                return false;
            }
            var modifiedSpell = spell.DeepCopy();
            var effect = modifiedSpell.Effects[spellToModify.EffectSlot];
            if (effect.Data == null)
            {
                Console.Out.WriteLine($"{spellToModify.EditorId} has no effects.");
                return false;
            }

            effect.Data.Magnitude = spellToModify.Magnitude;
            _state.PatchMod.Spells.Add(modifiedSpell);
            return true;
        }
    }
}