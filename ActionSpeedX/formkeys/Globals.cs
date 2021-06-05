using Mutagen.Bethesda;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace ActionSpeedX
{
    public static partial class FormKeys
    {
        public static class Globals
        {
            private static readonly ModKey ModKey                  = ModKey.FromNameAndExtension("ActionSpeedX.esp");
            public static FormLink<IGlobalGetter> ASX_AttackSpeed  => ModKey.MakeFormKey(0xb043);
            public static FormLink<IGlobalGetter> ASX_RAttackSpeed => ModKey.MakeFormKey(0xb044);
            public static FormLink<IGlobalGetter> ASX_PowerAttack  => ModKey.MakeFormKey(0xb045);
            public static FormLink<IGlobalGetter> ASX_SpellCost    => ModKey.MakeFormKey(0xb046);
            public static FormLink<IGlobalGetter> ASX_MagickaRegen => ModKey.MakeFormKey(0xb047);
            public static FormLink<IGlobalGetter> ASX_StaminaRegen => ModKey.MakeFormKey(0xb048);
            public static FormLink<IGlobalGetter> ASX_MoveSpeed    => ModKey.MakeFormKey(0xb041);
        }
    }
}
