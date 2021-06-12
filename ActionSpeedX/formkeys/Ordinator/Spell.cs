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
        public static class Spell
        {
            private static ModKey ModKey                                        = ModKey.FromNameAndExtension("Ordinator - Perks Of Skyrim.esp");
            public static FormLink<ISpellGetter> ORD_Lia_Windrunner_Spell_Ab    => ModKey.MakeFormKey(0x009B8D); 
            public static FormLink<ISpellGetter> ORD_Lia_FightOrFlight_Spell_Ab => ModKey.MakeFormKey(0x17C1DC); 

        }
    }
}