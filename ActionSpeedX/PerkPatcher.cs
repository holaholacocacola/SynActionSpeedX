using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Synthesis;
using Noggog;
using System;
using System.Collections.Generic;


namespace ActionSpeedX
{
    /// <summary>
    /// Disable global variables. These are checked when equipping items to determine which effects to distrubute.
    /// 
    /// </summary>
    public class PerkPatcher
    {
        //static ModKey Adamant   = ModKey.FromNameAndExtension("Adamant.esp");
        //static ModKey Vokrii    = ModKey.FromNameAndExtension("Vokrii - Minimalistic Perks of Skyrim.esp");
        static ModKey Ordinator = ModKey.FromNameAndExtension("Ordinator - Perks Of Skyrim.esp");
        private readonly IPatcherState<ISkyrimMod, ISkyrimModGetter> _state;
        private readonly ActionSpeedX.Settings _settings; // in memory rep of settings.json

        public PerkPatcher(IPatcherState<ISkyrimMod, ISkyrimModGetter> state, ActionSpeedX.Settings settings)
        {
            this._state = state;
            this._settings = settings;

        }

        public void PatchPerks()
        {
            if (this._state.LoadOrder.ContainsKey(Ordinator))
            {
                Console.WriteLine("Patching Ordinator Perks");
                PatchIt(FormKeys.OrdinatorPerks);
            }
            else
            { // Adamant and Vokrii use the same perks as vanilla.
                Console.WriteLine("Patching Perks");
                PatchIt(FormKeys.VanillaPerks);
            }
            
        
        }

        private void UpdateDescriptionAndAbilities(List<FormKeys.PerkModifier> perksToUpdate)
        {
            foreach(var perkModifier in perksToUpdate)
            {
                if(!this._state.LinkCache.TryResolve<IPerkGetter>(perkModifier.PerkForm.FormKey, out var perkUpdate) && perkUpdate != null)
                {
                    var modifiedPerk = perkUpdate.DeepCopy();
                    modifiedPerk.Description += perkModifier.Description;
                    foreach(var spellModifier in perkModifier.SpellForms)
                    {
                        if (!this._state.LinkCache.TryResolve<ISpellGetter>(spellModifier.FormKey, out var spellUpdate) && spellUpdate != null)
                        {
                            PerkAbilityEffect newAb = new();
                            newAb.Ability.SetTo(spellUpdate.FormKey);
                            modifiedPerk.Effects.Add(newAb);
                        }
                    }
                    this._state.PatchMod.Perks.Add(modifiedPerk);
                }   
            }
        }

        private void PatchIt(FormKeys.PerkModifiers modifyMe)
        {
            if (this._settings.StaminaRegen) UpdateDescriptionAndAbilities(modifyMe.StaminaPerks);
            if (this._settings.MagickaRegen) UpdateDescriptionAndAbilities(modifyMe.MagickaPerks);
            if (this._settings.MoveSpeed) UpdateDescriptionAndAbilities(modifyMe.SpeedPerks);
            if (this._settings.AttackSpeed) UpdateDescriptionAndAbilities(modifyMe.AttackSpeedPerks);
            if (this._settings.RangedAttack) UpdateDescriptionAndAbilities(modifyMe.RangedPerks);
        }
    }
}