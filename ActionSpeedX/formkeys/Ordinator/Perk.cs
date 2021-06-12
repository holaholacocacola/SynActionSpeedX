using Mutagen.Bethesda;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Skyrim;


namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Ordinator
    {

        /// <summary>
        /// This class contains abilities from ordinator that touch staminaratemult, and movementspeed. It contains instructions on how to rebalance those abilities.
        /// It covers the following perks: Windborne, Windrunner, Fight or Flight
        /// </summary>
        public static class Perk
        {
            private static readonly ModKey ModKey = ModKey.FromNameAndExtension("Ordinator - Perks of Skyrim.esp");

            // Power attacks
            public static FormLink<IPerkGetter> ORD_Alt00_AlterationMastery_Perk_00  => ModKey.MakeFormKey(0x0148ff);
            public static FormLink<IPerkGetter> ORD_Con00_ConjurationMastery_Perk_00 => ModKey.MakeFormKey(0x014900);
            public static FormLink<IPerkGetter> ORD_Des00_DestructionMastery_Perk_00 => ModKey.MakeFormKey(0X0148FD);
            public static FormLink<IPerkGetter> ORD_Ill00_IllusionMastery_Perk_00    => ModKey.MakeFormKey(0X0148FE);
            public static FormLink<IPerkGetter> ORD_Res00_RestorationMastery_Perk_00 => ModKey.MakeFormKey(0X014357);
            public static FormLink<IPerkGetter> ORD_Arc00_ArcheryMastery_Perk_00     => ModKey.MakeFormKey(0x00ABE1);
            public static FormLink<IPerkGetter> ORD_Hea00_HeavyArmorMastery_Perk_00  => ModKey.MakeFormKey(0x007AB2);
            public static FormLink<IPerkGetter> ORD_Lia00_LightArmorMastery_Perk_00  => ModKey.MakeFormKey(0x007AB0);
            public static FormLink<IPerkGetter> ORD_One00_OneHandedMastery_Perk_00   => ModKey.MakeFormKey(0x00B149);
            public static FormLink<IPerkGetter> ORD_Two00_TwoHandedMastery_Perk_00   => ModKey.MakeFormKey(0x00B14B);
        }
    }
}