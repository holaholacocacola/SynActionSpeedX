using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Skyrim;


namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class Vokrii
    {
        public static class Spell
        {
            
            private static ModKey ModKey = ModKey.FromNameAndExtension("Vokrii - Minimalistic Perks of Skyrim.esp");
            public static FormLink<ISpellGetter> VKR_Lia_Windrunner_Spell_Ab => ModKey.MakeFormKey(0x009B89); // Reduce move speed buff from 10% -> 1%

        }
    }
}