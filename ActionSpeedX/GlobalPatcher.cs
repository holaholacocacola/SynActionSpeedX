using Mutagen.Bethesda;
using Mutagen.Bethesda.FormKeys.SkyrimSE;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Plugins.Exceptions;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Synthesis;
using Newtonsoft.Json.Linq;
using Noggog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ActionSpeedX
{
    /// <summary>
    /// Disable global variables. These are checked when equipping items to determine which effects to distrubute.
    /// 
    /// </summary>
    public class GlobalPatcher
    {
        private readonly IPatcherState<ISkyrimMod, ISkyrimModGetter> state;
        private readonly ActionSpeedX.Settings settings; // in memory rep of settings.json

        public GlobalPatcher(IPatcherState<ISkyrimMod, ISkyrimModGetter> state, ActionSpeedX.Settings settings)
        {
            this.state    = state;
            this.settings = settings;

        }

        public void PatchGlobals()
        {
            if (!settings.AttackSpeed) DisableGlobal(FormKeys.Globals.ASX_AttackSpeed);
            if (!settings.RangedAttack) DisableGlobal(FormKeys.Globals.ASX_RAttackSpeed);
            if (!settings.StaminaRegen) DisableGlobal(FormKeys.Globals.ASX_StaminaRegen);
            if (!settings.MagickaRegen) DisableGlobal(FormKeys.Globals.ASX_MagickaRegen);
            if (!settings.MoveSpeed) DisableGlobal(FormKeys.Globals.ASX_MoveSpeed);
        }

        private void DisableGlobal(FormLink<IGlobalGetter> global)
        {
            if (!this.state.LinkCache.TryResolve<IGlobalGetter>(global.FormKey, out var outG))
            {
                throw new Exception($"Could not resolve form key for: {global}");
            }
            var modifiedGlobal = outG.DeepCopy();
            modifiedGlobal.RawFloat = 0;
            this.state.PatchMod.Globals.Add(modifiedGlobal);

        }
    }
}