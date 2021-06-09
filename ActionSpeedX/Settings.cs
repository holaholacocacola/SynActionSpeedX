using Mutagen.Bethesda.Synthesis.Settings;
namespace ActionSpeedX
{
    public enum PatchOption
    {
        Vanilla,
        Ordinator,
        Vokrii,
        Adamant
    }

    public class Settings 
    {
        [SynthesisOrder]
        [SynthesisSettingName("Enable Melee Attack Speed Effects")]
        [SynthesisDescription("Enable Melee Attack Speed Effects")]
        [SynthesisTooltip("Armor Affects Attack Speed")]
        public bool AttackSpeed { get; set; } = true;
        [SynthesisOrder]
        [SynthesisSettingName("Enable Ranged Weapon Speed Effects")]
        [SynthesisDescription("Enable Ranged Weapon Speed Effects")]
        [SynthesisTooltip("Armor Affects Ranged Attack Speed")]
        public bool RangedAttack { get; set; } = true;
        [SynthesisOrder]
        [SynthesisSettingName("Enable Movement Speed Effects")]
        [SynthesisDescription("Enable Movement Speed Effects")]
        [SynthesisTooltip("Armor Affects Movement Speed")]
        public bool MoveSpeed { get; set; } = true;
        [SynthesisOrder]
        [SynthesisSettingName("Enable Magicka Regeneration Effects")]
        [SynthesisDescription("Enable Magicka Regeneration Effects")]
        [SynthesisTooltip("Armor Affects Magicka Regeneration")]
        public bool MagickaRegen { get; set; } = false;
        [SynthesisOrder]
        [SynthesisSettingName("Enable Stamina Regeneration Effects")]
        [SynthesisDescription("Enable Stamina Regeneration Effects")]
        [SynthesisTooltip("Armor Affects Stamina Regeneration")]
        public bool StaminaRegen { get; set; } = false;
        [SynthesisOrder]
        [SynthesisSettingName("Enable Power Attack Costs Effects")]
        [SynthesisDescription("Enable Power Attack Costs Effects")]
        [SynthesisTooltip("Armor Affects Power Attack Costs")]
        public bool PowerAttacks { get; set; } = false;
        [SynthesisOrder]
        [SynthesisSettingName("Enable Spell Cost Effects")]
        [SynthesisDescription("Enable Spell Cost Effects")]
        [SynthesisTooltip("Armor Affects Spell Costs")]
        public bool SpellCosts { get; set; } = true;
        [SynthesisOrder]
        [SynthesisSettingName("Enable Racial Bonuses")]
        [SynthesisDescription("Enable Racial Bonuses")]
        [SynthesisTooltip("Race Affects Effect Magnitude")]
        public bool Racials { get; set; } = true;
        [SynthesisOrder]
        [SynthesisSettingName("Enable Faction Bonuses")]
        [SynthesisDescription("Enable Faction Bonuses")]
        [SynthesisTooltip("Faction Affects Effect Magnitude")]
        public bool Factions { get; set; } = true;
        [SynthesisOrder]
        [SynthesisSettingName("Rebalance Perk Mods")]
        [SynthesisDescription("Rebalance Perk Mods")]
        [SynthesisTooltip("Rescale passive speed/regeneration bonuses in Armor trees.")]
        public bool BalancePerkMods { get; set; } = true;
        [SynthesisOrder]
        [SynthesisSettingName("Enable Armor Descriptions")]
        [SynthesisDescription("Enable Armor Descriptions")]
        [SynthesisTooltip("Place Effect Descriptions on Armor.")]
        public bool Descriptions { get; set; } = false;
        [SynthesisOrder]
        [SynthesisSettingName("Enable Cuirass Only")]
        [SynthesisDescription("Enable Cuiriass Only")]
        [SynthesisTooltip("Effects are only attached to Chest pieces.")]
        public bool CuirassOnly { get; set; } = false;

        private PatchOption _patchOption = PatchOption.Vanilla;
        public void SetPatchOption(PatchOption value)
        {
            this._patchOption = value;
        }
        public PatchOption GetPatchOption()
        {
            return this._patchOption;
        }
    }
}