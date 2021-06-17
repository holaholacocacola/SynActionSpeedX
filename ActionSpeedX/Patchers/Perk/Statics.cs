using System.Collections.Generic;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.FormKeys.SkyrimSE;
using static Mutagen.Bethesda.FormKeys.SkyrimSE.ActionSpeedX_.Perk;
using Mutagen.Bethesda.Plugins;

namespace ActionSpeedX.Patchers
{
    
    public static class PerkStatics
    {
        // Unfortunately, these all must be const. No string subst
        const string ALTERATION_DESC = " Levels in Alteration will increase Magicka regeneration up to 5%.";
        const string CONJURATION_DESC = " Levels in Conjuration will increase Magicka regeneration up to 5%.";
        const string DESTRUCTION_DESC = " Levels in Destruction will increase Magicka regeneration up to 5%.";
        const string ILLUSION_DESC = " Levels in Illusion will increase Magicka regeneration up to 5%.";
        const string RESTORATION_DESC = " Levels in Restoration will increase Magicka regeneration up to 5%.";

        const string LIGHT_STAMINA_DESC = " Levels in Light Armor will increase Stamina regeneration up to 10%.";
        const string HEAVY_STAMINA_DESC = " Levels in Heavy Armor will increase Stamina regeneration up to 20%.";

        const string LIGHT_MOVE_DESC = " Levels in Light Armor will increase movement speed up to 10%.";
        const string HEAVY_MOVE_DESC = " Levels in Heavy Armor will increase movement speed up to 14%.";

        const string ARCHERY_DESC = " Levels in Archery will reduce draw/reload speed up to 16%.";
        const string ONE_HANDED_DESC = " Levels in One Handed will increase attack speed up to 10%.";
        const string TWO_HANDED_DESC = " Levels in Two Handed will increase attack speed up to 18%.";

        public static readonly List<FormLink<IPerkGetter>> PowerAttacks = new()
        {
            ASX_LightArmorBootsPowerAttackPenaltyPerk,
            ASX_LightArmorCuirassPowerAttackPenaltyPerk,
            ASX_LightArmorGauntletsPowerAttackPenaltyPerk,
            ASX_LightArmorHelmetPowerAttackPenaltyPerk,
            ASX_LightArmorShieldPowerAttackPenaltyPerk,
            ASX_HeavyArmorBootsPowerAttackPenaltyPerk,
            ASX_HeavyArmorCuirassPowerAttackPenaltyPerk,
            ASX_HeavyArmorGauntletsPowerAttackPenaltyPerk,
            ASX_HeavyArmorHelmetPowerAttackPenaltyPerk,
            ASX_HeavyArmorShieldPowerAttackPenaltyPerk,
            ASX_TwoHandedPowerAttackStaminaCostReductionPerk,
            ASX_OneHandedPowerAttackStaminaCostReductionPerk
        };

        public static readonly List<FormLink<IPerkGetter>> SpellCosts = new()
        {
            ASX_LightArmorBootsSpellCostPenaltyPerk,
            ASX_LightArmorCuirassSpellCostPenaltyPerk,
            ASX_LightArmorGauntletsSpellCostPenaltyPerk,
            ASX_LightArmorHelmetSpellCostPenaltyPerk,
            ASX_LightArmorShieldSpellCostPenaltyPerk,
            ASX_HeavyArmorBootsSpellCostPenaltyPerk,
            ASX_HeavyArmorCuirassSpellCostPenaltyPerk,
            ASX_HeavyArmorGauntletsSpellCostPenaltyPerk,
            ASX_HeavyArmorHelmetSpellCostPenaltyPerk,
            ASX_HeavyArmorShieldSpellCostPenaltyPerk,
            ASX_AlterationSpellCostReductionPerk,
            ASX_ConjurationSpellCostReductionPerk,
            ASX_DestructionSpellCostReductionPerk,
            ASX_IllusionSpellCostReductionPerk,
            ASX_RestorationSpellCostReductionPerk
        };

        public static readonly List<FormLink<IPerkGetter>> MoveSpeed = new()
        {
            ASX_LightArmorMoveSpeedPenaltiesPerk,
            ASX_ArmorSpeedMasteryPerk,
            ASX_HeavyArmorMoveSpeedPenaltiesPerk
        };

        public static readonly List<FormLink<IPerkGetter>> AttackSpeed = new()
        {
            ASX_LightArmorAttackSpeedPenaltiesPerk,
            ASX_HeavyArmorAttackSpeedPenaltiesPerk,
            ASX_OneHandedAttackSpeedBuffPerk,
            ASX_TwoHandedAttackSpeedBuffPerk
        };

        public static readonly List<FormLink<IPerkGetter>> MagickaRegen = new()
        {
            ASX_LightArmorMagickaRegenPenaltiesPerk,
            ASX_HeavyArmorMagickaRegenPenaltiesPerk,
            ASX_AlterationMagickaRegenPerk,
            ASX_ConjurationMagickaRegenPerk,
            ASX_DestructionMagickaRegenPerk,
            ASX_IllusionMagickaRegenPerk,
            ASX_RestorationMagickaRegenPerk
        };

        public static readonly List<FormLink<IPerkGetter>> StaminaRegen = new()
        {
            ASX_LightArmorStaminaRegenPenaltiesPerk,
            ASX_LightArmorStaminaRateMultBoostPerk,
            ASX_HeavyArmorStaminaRegenPenaltiesPerk,
            ASX_HeavyArmorStaminaRateMultBoostPerk
        };

        public static readonly List<FormLink<IPerkGetter>> RangedSpeed = new()
        {
            ASX_LightArmorRangedAttackSpeedPenaltiesPerk,
            ASX_HeavyArmorRangedAttackSpeedPenaltiesPerk,
            ASX_RangedAttackSpeedBoostPerk
        };


        // distribute by matching against RACE editor id. This is what needs to be updated for custom race proficiency perk support
        public static readonly Dictionary<string, FormLink<IPerkGetter>> RacialPerks = new()
        {
            { "ArgonianRace", ASX_ArgonianRacialProficiencyPerk },
            { "ArgonianRaceVampire", ASX_ArgonianRacialProficiencyPerk },
            { "DarkElfRace", ASX_DunmerRacialProficiencyPerk },
            { "DarkElfRaceVampire", ASX_DunmerRacialProficiencyPerk },
            { "ImperialRace", ASX_ImperialRacialProficiencyPerk },
            { "ImperialRaceVampire", ASX_ImperialRacialProficiencyPerk },
            { "NordRace", ASX_NordRacialProficiencyPerk },
            { "NordRaceVampire", ASX_NordRacialProficiencyPerk },
            { "OrcRace", ASX_OrcRacialProficiencyPerk },
            { "OrcRaceVampire", ASX_OrcRacialProficiencyPerk },
            { "RedguardRace", ASX_RedguardRacialProficiencyPerk },
            { "RedguardRaceVampire", ASX_RedguardRacialProficiencyPerk },
            { "WoodElfRace", ASX_BosmerRacialProficiencyPerk },
            { "WoodElfRaceVampire", ASX_BosmerRacialProficiencyPerk }
        };

        // These are distributed by looping through npc factions and matching against editorId.
        public static readonly Dictionary<string, FormLink<IPerkGetter>> FactionPerks = new()
        {
            { "CWImperialFaction", ASX_ImperialSoldierFactionProficiencyPerk },
            { "CWSonsFaction", ASX_StormcloakFactionProficiencyPerk },
            { "DraugrFaction", ASX_DraugrFactionProficiencyPerk },
            { "DremoraFaction", ASX_DremoraFactionProficiencyPerk },
            { "FalmerFaction", ASX_FalmerFactionProficiencyPerk },
            { "ForswornFaction", ASX_ForswornFactionProficiencyPerk },
            { "IsGuardFaction", ASX_GuardsFactionProficiencyPerk },
            { "DLC1HunterFaction", ASX_DawnguardFactionProficiencyPerk },
            { "ThalmorFaction", ASX_ThalmorFactionProficiencyPerk },
        };

        /* Perk Modifer and its Collections lets us determine which Perk needs a description updated, an ability appended
         */

        /// <summary>
        /// Contains PerkForm to Append Abilities and Description.
        /// </summary>
        public struct PerkModifier
        {
            public List<FormLink<ISpellGetter>> SpellForms; // Ability id
            public FormLink<IPerkGetter> PerkForm; // Perk id
            public string Description; // Appends text to Perk

            public PerkModifier(FormLink<IPerkGetter> perkForm, List<FormLink<ISpellGetter>> spellForms, string description)
            {
                this.PerkForm = perkForm;
                this.SpellForms = spellForms;
                this.Description = description;
            }
        }

        /// <summary>
        /// Contains multiple PerkModifier grouped based on patcher Settings.
        /// </summary>
        public struct PerkModifierCollection
        {
            public List<PerkModifier> StaminaPerks;
            public List<PerkModifier> MagickaPerks;
            public List<PerkModifier> SpeedPerks;
            public List<PerkModifier> AttackSpeedPerks;
            public List<PerkModifier> RangedPerks;

        }

        public static readonly PerkModifierCollection VanillaPerks = new()
        {
            StaminaPerks = new()
            {
                new PerkModifier(Skyrim.Perk.Juggernaut00, new List<FormLink<ISpellGetter>>() { ActionSpeedX_.Spell.ASX_HeavyArmorStaminaRateMultBoost }, HEAVY_STAMINA_DESC),
                new PerkModifier(Skyrim.Perk.AgileDefender00, new List<FormLink<ISpellGetter>>() { ActionSpeedX_.Spell.ASX_LightArmorStaminaRateMultBoost }, LIGHT_STAMINA_DESC)
            },
            MagickaPerks = new()
            {
                new PerkModifier(Skyrim.Perk.AlterationNovice00, new List<FormLink<ISpellGetter>>() { ActionSpeedX_.Spell.ASX_AlterationMagickaRegenAbility }, ALTERATION_DESC),
                new PerkModifier(Skyrim.Perk.ConjurationNovice00, new List<FormLink<ISpellGetter>>() { ActionSpeedX_.Spell.ASX_ConjurationMagickaRegenAbility }, CONJURATION_DESC),
                new PerkModifier(Skyrim.Perk.DestructionNovice00, new List<FormLink<ISpellGetter>>() { ActionSpeedX_.Spell.ASX_DestructionMagickaRegenAbility }, DESTRUCTION_DESC),
                new PerkModifier(Skyrim.Perk.IllusionNovice00, new List<FormLink<ISpellGetter>>() { ActionSpeedX_.Spell.ASX_IllusionMagickaRegenAbility }, ILLUSION_DESC),
                new PerkModifier(Skyrim.Perk.RestorationNovice00, new List<FormLink<ISpellGetter>>() { ActionSpeedX_.Spell.ASX_RestorationMagickaRegenAbility }, RESTORATION_DESC),
            },
            SpeedPerks = new()
            {
                new PerkModifier(Skyrim.Perk.Juggernaut00, new List<FormLink<ISpellGetter>>() { ActionSpeedX_.Spell.ASX_HeavyArmorMoveSpeedBoostNewAbility }, HEAVY_MOVE_DESC),
                new PerkModifier(Skyrim.Perk.AgileDefender00, new List<FormLink<ISpellGetter>>() { ActionSpeedX_.Spell.ASX_LightArmorMoveSpeedBoostSplitAbility }, LIGHT_MOVE_DESC)
            },
            AttackSpeedPerks = new()
            {
                new PerkModifier(Skyrim.Perk.Armsman00, ActionSpeedX_.Spell.OneHandedBoosts, ONE_HANDED_DESC),
                new PerkModifier(Skyrim.Perk.Barbarian00, ActionSpeedX_.Spell.TwoHandedBoosts, TWO_HANDED_DESC)
            },
            RangedPerks = new()
            {
                new PerkModifier(Skyrim.Perk.Overdraw00, ActionSpeedX_.Spell.ArcheryBoosts, ARCHERY_DESC),
            }
        };

        public static readonly PerkModifierCollection OrdinatorPerks = new()
        {
            StaminaPerks = new()
            {
                new PerkModifier(Ordinator.Perk.ORD_Hea00_HeavyArmorMastery_Perk_00, new List<FormLink<ISpellGetter>>() { ActionSpeedX_.Spell.ASX_HeavyArmorStaminaRateMultBoost }, HEAVY_STAMINA_DESC),
                new PerkModifier(Ordinator.Perk.ORD_Lia00_LightArmorMastery_Perk_00, new List<FormLink<ISpellGetter>>() { ActionSpeedX_.Spell.ASX_LightArmorStaminaRateMultBoost }, LIGHT_STAMINA_DESC)
            },
            MagickaPerks = new()
            {
                new PerkModifier(Ordinator.Perk.ORD_Alt00_AlterationMastery_Perk_00, new List<FormLink<ISpellGetter>>() { ActionSpeedX_.Spell.ASX_AlterationMagickaRegenAbility }, ALTERATION_DESC),
                new PerkModifier(Ordinator.Perk.ORD_Con00_ConjurationMastery_Perk_00, new List<FormLink<ISpellGetter>>() { ActionSpeedX_.Spell.ASX_ConjurationMagickaRegenAbility }, CONJURATION_DESC),
                new PerkModifier(Ordinator.Perk.ORD_Des00_DestructionMastery_Perk_00, new List<FormLink<ISpellGetter>>() { ActionSpeedX_.Spell.ASX_DestructionMagickaRegenAbility }, DESTRUCTION_DESC),
                new PerkModifier(Ordinator.Perk.ORD_Ill00_IllusionMastery_Perk_00, new List<FormLink<ISpellGetter>>() { ActionSpeedX_.Spell.ASX_IllusionMagickaRegenAbility }, ILLUSION_DESC),
                new PerkModifier(Ordinator.Perk.ORD_Res00_RestorationMastery_Perk_00, new List<FormLink<ISpellGetter>>() { ActionSpeedX_.Spell.ASX_RestorationMagickaRegenAbility }, RESTORATION_DESC),
            },
            SpeedPerks = new()
            {
                new PerkModifier(Ordinator.Perk.ORD_Hea00_HeavyArmorMastery_Perk_00, new List<FormLink<ISpellGetter>>() { ActionSpeedX_.Spell.ASX_HeavyArmorMoveSpeedBoostNewAbility }, HEAVY_MOVE_DESC),
                new PerkModifier(Ordinator.Perk.ORD_Lia00_LightArmorMastery_Perk_00, new List<FormLink<ISpellGetter>>() { ActionSpeedX_.Spell.ASX_LightArmorMoveSpeedBoostSplitAbility }, LIGHT_MOVE_DESC)
            },
            AttackSpeedPerks = new()
            {
                new PerkModifier(Ordinator.Perk.ORD_One00_OneHandedMastery_Perk_00, ActionSpeedX_.Spell.OneHandedBoosts, ONE_HANDED_DESC),
                new PerkModifier(Ordinator.Perk.ORD_Two00_TwoHandedMastery_Perk_00, ActionSpeedX_.Spell.TwoHandedBoosts, TWO_HANDED_DESC)
            },
            RangedPerks = new()
            {
                new PerkModifier(Ordinator.Perk.ORD_Arc00_ArcheryMastery_Perk_00, ActionSpeedX_.Spell.ArcheryBoosts, ARCHERY_DESC)
            }
        };

    }
}