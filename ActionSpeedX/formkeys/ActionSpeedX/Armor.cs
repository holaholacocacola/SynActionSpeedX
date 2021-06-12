using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class ActionSpeedX_
    {
        public static class Armor
        {
            private static readonly ModKey ModKey = ModKey.FromNameAndExtension("ActionSpeedX.esp");
            public static  FormLink<IArmorGetter> ASX_ArmorTemplate => ModKey.MakeFormKey(0x00CD67);
            public static FormLink<IArmorGetter> ASX_ShieldTemplate => ModKey.MakeFormKey(0x00D2C9);

        }
    }
}