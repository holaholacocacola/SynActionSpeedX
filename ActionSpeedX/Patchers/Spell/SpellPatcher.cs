using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Synthesis;
using Noggog;
using System;
using System.Collections.Generic;

using Statics = ActionSpeedX.Patchers.SpellStatics;

namespace ActionSpeedX
{
    public class SpellPatcher
    {
       
        private readonly IPatcherState<ISkyrimMod, ISkyrimModGetter> _state;
        private readonly Settings _settings; // in memory rep of settings.json
        public SpellPatcher(IPatcherState<ISkyrimMod, ISkyrimModGetter> state, Settings settings)
        {
            this._state    = state;
            this._settings = settings;
        }

        public void Run()
        {
            // check all supported mods because of abominations like vokriinator black
            bool success;
            if (this._settings.GetPatchOption() == PatchOption.Adamant)
            {
                success = RebalanceSpells(Statics.AdamantSpellEffectMappings.StaminaSpells, Statics.AdamantSpellEffectMappings.SpeedSpells) && UpdatePerkDescriptions(Statics.AdamantPerkMappings);
                if (!success) throw new Exception("Failed to patch adamant");
            }

            else if (this._settings.GetPatchOption() == PatchOption.Ordinator)
            {
                success = RebalanceSpells(Statics.OrdinatorSpellEffectMappings.StaminaSpells, Statics.OrdinatorSpellEffectMappings.SpeedSpells) && UpdatePerkDescriptions(Statics.EnaiPerkMappings);
                if (!success) throw new Exception("Failed to patch ordinator");
            }

            else if (this._settings.GetPatchOption() == PatchOption.Vokrii)
            {
                success = RebalanceSpells(Statics.VokriiSpellEffectMappings.StaminaSpells, Statics.VokriiSpellEffectMappings.SpeedSpells) && UpdatePerkDescriptions(Statics.EnaiPerkMappings);
                if (!success) throw new Exception("Failed to patch vokrii");
            }
           
        }

        private bool UpdatePerkDescriptions(Statics.PerkDescriptionMappings perkMap)
        {
            if (this._settings.StaminaRegen && !UpdatePerkDescription(perkMap.StaminaPerks)) return false;
            if (this._settings.MoveSpeed && !UpdatePerkDescription(perkMap.SpeedPerks)) return false;
            return true;
        }

        private bool UpdatePerkDescription(List<Statics.PerkDescriptionMapping> perkUps)
        {
            foreach (var perkUp in perkUps)
            {
                if (!this._state.LinkCache.TryResolve<IPerkGetter>(perkUp.PerkForm.FormKey, out var perk))
                {
                    Console.Out.WriteLine($"Could not resolve form key for: {perkUp}");
                    return false;
                }
                var perkUpdate = perk.DeepCopy();
                perkUpdate.Description = perkUp.Description;
                _state.PatchMod.Perks.Set(perkUpdate); // not thread safe
            }
            return true;
        }

        private bool RebalanceSpells(List<Statics.SpellFormEffectsMagnitudeMapping> staminaSpells, List<Statics.SpellFormEffectsMagnitudeMapping> speedSpells)
        {
            bool hasError = false;
            if (this._settings.StaminaRegen)
            {
                foreach (var stamModifier in staminaSpells)
                {
                    if (!AdjustSpellEffect(stamModifier)) hasError = true;
                }
            }

            if (this._settings.MoveSpeed)
            {
                foreach (var speedModifier in speedSpells)
                {
                    if (!AdjustSpellEffect(speedModifier)) hasError = true;
                }
            }

            return !hasError;
        }

        private bool AdjustSpellEffect(Statics.SpellFormEffectsMagnitudeMapping spellToModify)
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
            _state.PatchMod.Spells.Set(modifiedSpell);
            return true;
        }
    }
}