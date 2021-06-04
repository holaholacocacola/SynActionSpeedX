using System;
using System.Collections.Generic;
using Mutagen.Bethesda;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace ActionSpeedX
{
    public static partial class FormKeys
    {
        public static class Armor
        {
            private static readonly ModKey ModKey = ModKey.FromNameAndExtension("ActionSpeedX.esp");
            public static  FormLink<IArmorGetter> ASX_ArmorTemplate => ModKey.MakeFormKey(0x00CD67);
            //private static FormLink<IArmorGetter> ASX_SheildTemplate => ModKey.MakeFormKey(0x00CD67);

        }
    }
}