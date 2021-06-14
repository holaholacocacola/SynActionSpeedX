using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Adamant
    {
        public static class Perk
        {

            private static ModKey ModKey = ModKey.FromNameAndExtension("Adamant.esp");
            public static FormLink<IPerkGetter> MAG_Agility30 => ModKey.MakeFormKey(0xD01CC); // This will be reduced from 50% -> 5%. Affects stamina regeneration. 
            public static FormLink<IPerkGetter> MAG_Agility60 => ModKey.MakeFormKey(0x0F38D8); // This will be reduced from 100% -> 5%. Affects stamina regeneration
            public static FormLink<IPerkGetter> MAG_Athletics40 => Skyrim.Perk.WindWalker; // This will be reduced from 10 -> 1%. Affects movement speed
            public static FormLink<IPerkGetter> MAG_Athletics60 => ModKey.MakeFormKey(0x153BF8); // This will be reduced from 10-> 2%. Affects movement speed.

        }


    }
}