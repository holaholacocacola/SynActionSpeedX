using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Adamant
    {
        public static class Spell
        {

            private static ModKey ModKey = ModKey.FromNameAndExtension("Adamant.esp");
            public static FormLink<ISpellGetter> MAG_PerkAgility30 => Skyrim.Spell.PerkWindWalkerStamina.FormKey; // This will be reduced from 50% -> 5%. Affects stamina regeneration. 
            public static FormLink<ISpellGetter> MAG_PerkAgility60 => ModKey.MakeFormKey(0x0F38DA); // This will be reduced from 100% -> 5%. Affects stamina regeneration
            public static FormLink<ISpellGetter> MAG_abAthletics40 => ModKey.MakeFormKey(0x0F38D7); // This will be reduced from 10 -> 1%. Affects movement speed
            public static FormLink<ISpellGetter> MAG_abAthletics60 => ModKey.MakeFormKey(0x153BF7); // This will be reduced from 10-> 2%. Affects movement speed.

        }


    }
}