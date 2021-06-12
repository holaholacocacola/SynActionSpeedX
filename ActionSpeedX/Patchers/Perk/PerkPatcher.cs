using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Synthesis;
using Noggog;
using System;
using System.Collections.Generic;

using Statics = ActionSpeedX.Patchers.PerkStatics;

namespace ActionSpeedX.Patchers
{

    public class PerkPatcher
    {
        private readonly IPatcherState<ISkyrimMod, ISkyrimModGetter> _state;
        private readonly Settings _settings; // in memory rep of settings.json

        public PerkPatcher(IPatcherState<ISkyrimMod, ISkyrimModGetter> state, ActionSpeedX.Settings settings)
        {
            this._state = state;
            this._settings = settings;

        }


        public void Run()
        {
            if (this._settings.GetPatchOption() == PatchOption.Ordinator)
            {
                PatchIt(Statics.OrdinatorPerks);
            }
            else
            { // Adamant and Vokrii use the same perks as vanilla.
                PatchIt(Statics.VanillaPerks);
            }
        }

        /// <summary>
        /// Appends Abilities and Updates Perk Description
        /// </summary>
        /// <param name="perksToUpdate"></param>
        private void UpdatePerkDescriptionAndAbilities(List<Statics.PerkModifier> perksToUpdate)
        {
            foreach(var perkModifier in perksToUpdate)
            {
                if(this._state.LinkCache.TryResolve<IPerkGetter>(perkModifier.PerkForm.FormKey, out var perkUpdate))
                {
                    var modifiedPerk =  perkUpdate.DeepCopy();
                    modifiedPerk.Description += perkModifier.Description;
                    foreach(var spellModifier in perkModifier.SpellForms)
                    {
                        if (this._state.LinkCache.TryResolve<ISpellGetter>(spellModifier.FormKey, out var spellUpdate))
                        {
                            PerkAbilityEffect newAb = new();
                            newAb.Ability.SetTo(spellUpdate.FormKey);
                            modifiedPerk.Effects.Add(newAb);
                        }
                    }
                    this._state.PatchMod.Perks.Set(modifiedPerk);
                }
                else
                {
                    throw new Exception("Could not resolve formkey for.");
                }
            }
        }

        private void PatchIt(Statics.PerkModifierCollection modifyMe)
        {
            if (this._settings.StaminaRegen) UpdatePerkDescriptionAndAbilities(modifyMe.StaminaPerks);
            if (this._settings.MagickaRegen) UpdatePerkDescriptionAndAbilities(modifyMe.MagickaPerks);
            if (this._settings.MoveSpeed) UpdatePerkDescriptionAndAbilities(modifyMe.SpeedPerks);
            if (this._settings.AttackSpeed) UpdatePerkDescriptionAndAbilities(modifyMe.AttackSpeedPerks);
            if (this._settings.RangedAttack) UpdatePerkDescriptionAndAbilities(modifyMe.RangedPerks);
        }
    }
}