using Mutagen.Bethesda.FormKeys.SkyrimSE;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Synthesis;
using Noggog;
using System;


namespace ActionSpeedX.Patchers
{
    /// <summary>
    /// Disable global variables. These are checked when equipping items to determine which effects to distribute and which loadscreens are active
    /// 
    /// </summary>
    public class GlobalPatcher
    {
        private readonly IPatcherState<ISkyrimMod, ISkyrimModGetter> _state;
        private readonly Settings _settings;

        public GlobalPatcher(IPatcherState<ISkyrimMod, ISkyrimModGetter> state, ActionSpeedX.Settings settings)
        {
            this._state    = state;
            this._settings = settings;
        }

        public void Run()
        {
            if (!_settings.AttackSpeed) DisableGlobal(ActionSpeedX_.Global.ASX_AttackSpeed);
            if (!_settings.RangedAttack) DisableGlobal(ActionSpeedX_.Global.ASX_RAttackSpeed);
            if (!_settings.StaminaRegen) DisableGlobal(ActionSpeedX_.Global.ASX_StaminaRegen);
            if (!_settings.MagickaRegen) DisableGlobal(ActionSpeedX_.Global.ASX_MagickaRegen);
            if (!_settings.MoveSpeed) DisableGlobal(ActionSpeedX_.Global.ASX_MoveSpeed);
        }

        private void DisableGlobal(FormLink<IGlobalGetter> global)
        {
            if (!this._state.LinkCache.TryResolve<IGlobalGetter>(global.FormKey, out var outG))
            {
                throw new Exception($"Could not resolve form key for: {global}");
            }
            var modifiedGlobal      = outG.DeepCopy();
            modifiedGlobal.RawFloat = 0;
            this._state.PatchMod.Globals.Add(modifiedGlobal);
        }
    }
}