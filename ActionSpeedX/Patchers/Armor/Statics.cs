using System;
using System.Collections.Generic;
using Mutagen.Bethesda.Skyrim;
using static Mutagen.Bethesda.FormKeys.SkyrimSE.ActionSpeedX_.Keywords;
using static Mutagen.Bethesda.FormKeys.SkyrimSE.ActionSpeedX_.Spell;
using Mutagen.Bethesda.Plugins;

namespace ActionSpeedX.Patchers
{
    /// <summary>
    /// 
    /// This contains the 5 spell components that are attached to armors excluding shields.
    /// </summary>
    public class ArmorActionSpells
    {
        public FormLink<ISpellGetter> AttackSpell;
        public FormLink<ISpellGetter>? RangedAttackSpell;
        public FormLink<ISpellGetter> SpeedSpell;
        public FormLink<ISpellGetter> MagickaSpell;
        public FormLink<ISpellGetter> StaminaSpell;

        public ArmorActionSpells(FormLink<ISpellGetter> attack, FormLink<ISpellGetter>? rangedAttack, FormLink<ISpellGetter> speed, FormLink<ISpellGetter> magicka, FormLink<ISpellGetter> stamina)
        {
            this.AttackSpell = attack;
            this.RangedAttackSpell = rangedAttack;
            this.SpeedSpell = speed;
            this.MagickaSpell = magicka;
            this.StaminaSpell = stamina;
        }
    }

    public static class ArmorStatics
    {
        
        // Light armor keywords that will be added to equipment
        static readonly List<FormLink<IKeywordGetter>> LightBoots     = new() { ASX_LightArmorBootsT1, ASX_LightArmorBootsT2, ASX_LightArmorBootsT3, ASX_LightArmorBootsT4 };
        static readonly List<FormLink<IKeywordGetter>> LightCuirass   = new() { ASX_LightArmorCuirassT1, ASX_LightArmorCuirassT2, ASX_LightArmorCuirassT3, ASX_LightArmorCuirassT4 };
        static readonly List<FormLink<IKeywordGetter>> LightGauntlets = new() { ASX_LightArmorGauntletsT1, ASX_LightArmorGauntletsT2, ASX_LightArmorGauntletsT3, ASX_LightArmorGauntletsT4 };
        static readonly List<FormLink<IKeywordGetter>> LightHelmet    = new() { ASX_LightArmorHelmetT1, ASX_LightArmorHelmetT2, ASX_LightArmorHelmetT3, ASX_LightArmorHelmetT4 };
        static readonly List<FormLink<IKeywordGetter>> LightShield    = new() { ASX_LightArmorShieldT1, ASX_LightArmorShieldT2, ASX_LightArmorShieldT3, ASX_LightArmorShieldT4 };

        /*
        static readonly List<FormLink<IKeywordGetter> > mediumBoots     = new() { ASX_MediumArmorBootsT1, ASX_MediumArmorBootsT2, ASX_MediumArmorBootsT3, ASX_MediumArmorBootsT4 };
        static readonly List<FormLink<IKeywordGetter> > mediumCuirass   = new() { ASX_MediumArmorCuirassT1, ASX_MediumArmorCuirassT2, ASX_MediumArmorCuirassT3, ASX_MediumArmorCuirassT4 };
        static readonly List<FormLink<IKeywordGetter> > mediumGauntlets = new() { ASX_MediumArmorGauntletsT1, ASX_MediumArmorGauntletsT2, ASX_MediumArmorGauntletsT3, ASX_MediumArmorGauntletsT4 };
        static readonly List<FormLink<IKeywordGetter> > mediumHelmet    = new() { ASX_MediumArmorHelmetT1, ASX_MediumArmorHelmetT2, ASX_MediumArmorHelmetT3, ASX_MediumArmorHelmetT4 };
        static readonly List<FormLink<IKeywordGetter> > mediumShield    = new() { ASX_MediumArmorShieldT1, ASX_MediumArmorShieldT2, ASX_MediumArmorShieldT3, ASX_MediumArmorShieldT4 };
        */

        // Heavy armor keywords that will be added to equipment
        static readonly List<FormLink<IKeywordGetter>> HeavyBoots     = new() { ASX_HeavyArmorBootsT1, ASX_HeavyArmorBootsT2, ASX_HeavyArmorBootsT3, ASX_HeavyArmorBootsT4 };
        static readonly List<FormLink<IKeywordGetter>> HeavyCuirass   = new() { ASX_HeavyArmorCuirassT1, ASX_HeavyArmorCuirassT2, ASX_HeavyArmorCuirassT3, ASX_HeavyArmorCuirassT4 };
        static readonly List<FormLink<IKeywordGetter>> HeavyGauntlets = new() { ASX_HeavyArmorGauntletsT1, ASX_HeavyArmorGauntletsT2, ASX_HeavyArmorGauntletsT3, ASX_HeavyArmorGauntletsT4 };
        static readonly List<FormLink<IKeywordGetter>> HeavyHelmet    = new() { ASX_HeavyArmorHelmetT1, ASX_HeavyArmorHelmetT2, ASX_HeavyArmorHelmetT3, ASX_HeavyArmorHelmetT4 };
        static readonly List<FormLink<IKeywordGetter>> HeavyShield    = new() { ASX_HeavyArmorShieldT1, ASX_HeavyArmorShieldT2, ASX_HeavyArmorShieldT3, ASX_HeavyArmorShieldT4 };

        public static readonly Dictionary<String, List<FormLink<IKeywordGetter>>> LightArmorKeywordCollection = new Dictionary<string, List<FormLink<IKeywordGetter>>> {
            { "Boots", LightBoots },
            { "Cuirass", LightCuirass },
            { "Gauntlets", LightGauntlets },
            { "Helmet", LightHelmet},
            { "Shield", LightShield}
        };

        public static readonly Dictionary<String, List<FormLink<IKeywordGetter>>> HeavyArmorKeywordCollection = new Dictionary<string, List<FormLink<IKeywordGetter>>> {
            { "Boots", HeavyBoots },
            { "Cuirass", HeavyCuirass },
            { "Gauntlets", HeavyGauntlets },
            { "Helmet", HeavyHelmet},
            { "Shield", HeavyShield}
        };

        /*
         * public static readonly Dictionary<String, List<FormLink<IKeywordGetter> >> mediumArmorKeys = new Dictionary<string, List<FormLink<IKeywordGetter> >> {
            { "Boots", mediumBoots },
            { "Cuirass", mediumCuirass },
            { "Gauntlets", mediumGauntlets },
            { "Helmet", mediumHelmet},
            { "Shield", mediumShield}
        }; */

        static readonly List<ArmorActionSpells> LightBootSpells = new()
        {
            new ArmorActionSpells(ASX_LightArmorBootsAttackSpeedPenaltyAbility1, ASX_LightArmorBootsRangedSpeedPenaltyAbility1, ASX_LightArmorBootsMovementSpeedPenaltyAbility1, ASX_LightArmorBootsMagicaRateMultPenaltyAbility1, ASX_LightArmorBootsStaminaRateMultPenaltyAbility1),
            new ArmorActionSpells(ASX_LightArmorBootsAttackSpeedPenaltyAbility2, ASX_LightArmorBootsRangedSpeedPenaltyAbility2, ASX_LightArmorBootsMovementSpeedPenaltyAbility2, ASX_LightArmorBootsMagicaRateMultPenaltyAbility2, ASX_LightArmorBootsStaminaRateMultPenaltyAbility2),
            new ArmorActionSpells(ASX_LightArmorBootsAttackSpeedPenaltyAbility3, ASX_LightArmorBootsRangedSpeedPenaltyAbility3, ASX_LightArmorBootsMovementSpeedPenaltyAbility3, ASX_LightArmorBootsMagicaRateMultPenaltyAbility3, ASX_LightArmorBootsStaminaRateMultPenaltyAbility3),
            new ArmorActionSpells(ASX_LightArmorBootsAttackSpeedPenaltyAbility4, ASX_LightArmorBootsRangedSpeedPenaltyAbility4, ASX_LightArmorBootsMovementSpeedPenaltyAbility4, ASX_LightArmorBootsMagicaRateMultPenaltyAbility4, ASX_LightArmorBootsStaminaRateMultPenaltyAbility4)

        };
        static readonly List<ArmorActionSpells> LightCuirassSpells = new()
        {
            new ArmorActionSpells(ASX_LightArmorCuirassAttackSpeedPenaltyAbility1, ASX_LightArmorCuirassRangedSpeedPenaltyAbility1, ASX_LightArmorCuirassMovementSpeedPenaltyAbility1, ASX_LightArmorCuirassMagicaRateMultPenaltyAbility1, ASX_LightArmorCuirassStaminaRateMultPenaltyAbility1),
            new ArmorActionSpells(ASX_LightArmorCuirassAttackSpeedPenaltyAbility2, ASX_LightArmorCuirassRangedSpeedPenaltyAbility2, ASX_LightArmorCuirassMovementSpeedPenaltyAbility2, ASX_LightArmorCuirassMagicaRateMultPenaltyAbility2, ASX_LightArmorCuirassStaminaRateMultPenaltyAbility2),
            new ArmorActionSpells(ASX_LightArmorCuirassAttackSpeedPenaltyAbility3, ASX_LightArmorCuirassRangedSpeedPenaltyAbility3, ASX_LightArmorCuirassMovementSpeedPenaltyAbility3, ASX_LightArmorCuirassMagicaRateMultPenaltyAbility3, ASX_LightArmorCuirassStaminaRateMultPenaltyAbility3),
            new ArmorActionSpells(ASX_LightArmorCuirassAttackSpeedPenaltyAbility4, ASX_LightArmorCuirassRangedSpeedPenaltyAbility4, ASX_LightArmorCuirassMovementSpeedPenaltyAbility4, ASX_LightArmorCuirassMagicaRateMultPenaltyAbility4, ASX_LightArmorCuirassStaminaRateMultPenaltyAbility4)

        };
        static readonly List<ArmorActionSpells> LightGauntletsSpells = new()
        {
            new ArmorActionSpells(ASX_LightArmorGauntletsAttackSpeedPenaltyAbility1, ASX_LightArmorGauntletsRangedSpeedPenaltyAbility1, ASX_LightArmorGauntletsMovementSpeedPenaltyAbility1, ASX_LightArmorGauntletsMagicaRateMultPenaltyAbility1, ASX_LightArmorGauntletsStaminaRateMultPenaltyAbility1),
            new ArmorActionSpells(ASX_LightArmorGauntletsAttackSpeedPenaltyAbility2, ASX_LightArmorGauntletsRangedSpeedPenaltyAbility2, ASX_LightArmorGauntletsMovementSpeedPenaltyAbility2, ASX_LightArmorGauntletsMagicaRateMultPenaltyAbility2, ASX_LightArmorGauntletsStaminaRateMultPenaltyAbility2),
            new ArmorActionSpells(ASX_LightArmorGauntletsAttackSpeedPenaltyAbility3, ASX_LightArmorGauntletsRangedSpeedPenaltyAbility3, ASX_LightArmorGauntletsMovementSpeedPenaltyAbility3, ASX_LightArmorGauntletsMagicaRateMultPenaltyAbility3, ASX_LightArmorGauntletsStaminaRateMultPenaltyAbility3),
            new ArmorActionSpells(ASX_LightArmorGauntletsAttackSpeedPenaltyAbility4, ASX_LightArmorGauntletsRangedSpeedPenaltyAbility4, ASX_LightArmorGauntletsMovementSpeedPenaltyAbility4, ASX_LightArmorGauntletsMagicaRateMultPenaltyAbility4, ASX_LightArmorGauntletsStaminaRateMultPenaltyAbility4)

        };
        static readonly List<ArmorActionSpells> LightHelmetSpells = new()
        {
            new ArmorActionSpells(ASX_LightArmorHelmetAttackSpeedPenaltyAbility1, ASX_LightArmorHelmetRangedSpeedPenaltyAbility1, ASX_LightArmorHelmetMovementSpeedPenaltyAbility1, ASX_LightArmorHelmetMagicaRateMultPenaltyAbility1, ASX_LightArmorHelmetStaminaRateMultPenaltyAbility1),
            new ArmorActionSpells(ASX_LightArmorHelmetAttackSpeedPenaltyAbility2, ASX_LightArmorHelmetRangedSpeedPenaltyAbility2, ASX_LightArmorHelmetMovementSpeedPenaltyAbility2, ASX_LightArmorHelmetMagicaRateMultPenaltyAbility2, ASX_LightArmorHelmetStaminaRateMultPenaltyAbility2),
            new ArmorActionSpells(ASX_LightArmorHelmetAttackSpeedPenaltyAbility3, ASX_LightArmorHelmetRangedSpeedPenaltyAbility3, ASX_LightArmorHelmetMovementSpeedPenaltyAbility3, ASX_LightArmorHelmetMagicaRateMultPenaltyAbility3, ASX_LightArmorHelmetStaminaRateMultPenaltyAbility3),
            new ArmorActionSpells(ASX_LightArmorHelmetAttackSpeedPenaltyAbility4, ASX_LightArmorHelmetRangedSpeedPenaltyAbility4, ASX_LightArmorHelmetMovementSpeedPenaltyAbility4, ASX_LightArmorHelmetMagicaRateMultPenaltyAbility4, ASX_LightArmorHelmetStaminaRateMultPenaltyAbility4)

        };
        static readonly List<ArmorActionSpells> LightShieldSpells = new()
        {
            new ArmorActionSpells(ASX_LightArmorShieldAttackSpeedPenaltyAbility1, null, ASX_LightArmorShieldMovementSpeedPenaltyAbility1, ASX_LightArmorShieldMagicaRateMultPenaltyAbility1, ASX_LightArmorShieldStaminaRateMultPenaltyAbility1),
            new ArmorActionSpells(ASX_LightArmorShieldAttackSpeedPenaltyAbility2, null, ASX_LightArmorShieldMovementSpeedPenaltyAbility2, ASX_LightArmorShieldMagicaRateMultPenaltyAbility2, ASX_LightArmorShieldStaminaRateMultPenaltyAbility2),
            new ArmorActionSpells(ASX_LightArmorShieldAttackSpeedPenaltyAbility3, null, ASX_LightArmorShieldMovementSpeedPenaltyAbility3, ASX_LightArmorShieldMagicaRateMultPenaltyAbility3, ASX_LightArmorShieldStaminaRateMultPenaltyAbility3),
            new ArmorActionSpells(ASX_LightArmorShieldAttackSpeedPenaltyAbility4, null, ASX_LightArmorShieldMovementSpeedPenaltyAbility4, ASX_LightArmorShieldMagicaRateMultPenaltyAbility4, ASX_LightArmorShieldStaminaRateMultPenaltyAbility4)

        };
       
        /*************************************************************************************************Heavy**************************************************************************************/
        static readonly List<ArmorActionSpells> HeavyBootSpells = new()
        {
            new ArmorActionSpells(ASX_HeavyArmorBootsAttackSpeedPenaltyAbility1, ASX_HeavyArmorBootsRangedSpeedPenaltyAbility1, ASX_HeavyArmorBootsMovementSpeedPenaltyAbility1, ASX_HeavyArmorBootsMagickaRateMultPenaltyAbility1, ASX_HeavyArmorBootsStaminaRateMultPenaltyAbility1),
            new ArmorActionSpells(ASX_HeavyArmorBootsAttackSpeedPenaltyAbility2, ASX_HeavyArmorBootsRangedSpeedPenaltyAbility2, ASX_HeavyArmorBootsMovementSpeedPenaltyAbility2, ASX_HeavyArmorBootsMagickaRateMultPenaltyAbility2, ASX_HeavyArmorBootsStaminaRateMultPenaltyAbility2),
            new ArmorActionSpells(ASX_HeavyArmorBootsAttackSpeedPenaltyAbility3, ASX_HeavyArmorBootsRangedSpeedPenaltyAbility3, ASX_HeavyArmorBootsMovementSpeedPenaltyAbility3, ASX_HeavyArmorBootsMagickaRateMultPenaltyAbility3, ASX_HeavyArmorBootsStaminaRateMultPenaltyAbility3),
            new ArmorActionSpells(ASX_HeavyArmorBootsAttackSpeedPenaltyAbility4, ASX_HeavyArmorBootsRangedSpeedPenaltyAbility4, ASX_HeavyArmorBootsMovementSpeedPenaltyAbility4, ASX_HeavyArmorBootsMagickaRateMultPenaltyAbility4, ASX_HeavyArmorBootsStaminaRateMultPenaltyAbility4)

        };
        static readonly List<ArmorActionSpells> HeavyCuirassSpells = new()
        {
            new ArmorActionSpells(ASX_HeavyArmorCuirassAttackSpeedPenaltyAbility1, ASX_HeavyArmorCuirassRangedSpeedPenaltyAbility1, ASX_HeavyArmorCuirassMovementSpeedPenaltyAbility1, ASX_HeavyArmorCuirassMagickaRateMultPenaltyAbility1, ASX_HeavyArmorCuirassStaminaRateMultPenaltyAbility1),
            new ArmorActionSpells(ASX_HeavyArmorCuirassAttackSpeedPenaltyAbility2, ASX_HeavyArmorCuirassRangedSpeedPenaltyAbility2, ASX_HeavyArmorCuirassMovementSpeedPenaltyAbility2, ASX_HeavyArmorCuirassMagickaRateMultPenaltyAbility2, ASX_HeavyArmorCuirassStaminaRateMultPenaltyAbility2),
            new ArmorActionSpells(ASX_HeavyArmorCuirassAttackSpeedPenaltyAbility3, ASX_HeavyArmorCuirassRangedSpeedPenaltyAbility3, ASX_HeavyArmorCuirassMovementSpeedPenaltyAbility3, ASX_HeavyArmorCuirassMagickaRateMultPenaltyAbility3, ASX_HeavyArmorCuirassStaminaRateMultPenaltyAbility3),
            new ArmorActionSpells(ASX_HeavyArmorCuirassAttackSpeedPenaltyAbility4, ASX_HeavyArmorCuirassRangedSpeedPenaltyAbility4, ASX_HeavyArmorCuirassMovementSpeedPenaltyAbility4, ASX_HeavyArmorCuirassMagickaRateMultPenaltyAbility4, ASX_HeavyArmorCuirassStaminaRateMultPenaltyAbility4)

        };
        static readonly List<ArmorActionSpells> HeavyGauntletsSpells = new()
        {
            new ArmorActionSpells(ASX_HeavyArmorGauntletsAttackSpeedPenaltyAbility1, ASX_HeavyArmorGauntletsRangedSpeedPenaltyAbility1, ASX_HeavyArmorGauntletsMovementSpeedPenaltyAbility1, ASX_HeavyArmorGlovesMagickaRateMultPenaltyAbility1, ASX_HeavyArmorGlovesStaminaRateMultPenaltyAbility1),
            new ArmorActionSpells(ASX_HeavyArmorGauntletsAttackSpeedPenaltyAbility2, ASX_HeavyArmorGauntletsRangedSpeedPenaltyAbility2, ASX_HeavyArmorGauntletsMovementSpeedPenaltyAbility2, ASX_HeavyArmorGlovesMagickaRateMultPenaltyAbility2, ASX_HeavyArmorGlovesStaminaRateMultPenaltyAbility2),
            new ArmorActionSpells(ASX_HeavyArmorGauntletsAttackSpeedPenaltyAbility3, ASX_HeavyArmorGauntletsRangedSpeedPenaltyAbility3, ASX_HeavyArmorGauntletsMovementSpeedPenaltyAbility3, ASX_HeavyArmorGlovesMagickaRateMultPenaltyAbility3, ASX_HeavyArmorGlovesStaminaRateMultPenaltyAbility3),
            new ArmorActionSpells(ASX_HeavyArmorGauntletsAttackSpeedPenaltyAbility4, ASX_HeavyArmorGauntletsRangedSpeedPenaltyAbility4, ASX_HeavyArmorGauntletsMovementSpeedPenaltyAbility4, ASX_HeavyArmorGlovesMagickaRateMultPenaltyAbility4, ASX_HeavyArmorGlovesStaminaRateMultPenaltyAbility4)

        };
        static readonly List<ArmorActionSpells> HeavyHelmetSpells = new()
        {
            new ArmorActionSpells(ASX_HeavyArmorHelmetAttackSpeedPenaltyAbility1, ASX_HeavyArmorHelmetRangedSpeedPenaltyAbility1, ASX_HeavyArmorHelmetMovementSpeedPenaltyAbility1, ASX_HeavyArmorHelmetMagickaRateMultPenaltyAbility1, ASX_HeavyArmorHelmetStaminaRateMultPenaltyAbility1),
            new ArmorActionSpells(ASX_HeavyArmorHelmetAttackSpeedPenaltyAbility2, ASX_HeavyArmorHelmetRangedSpeedPenaltyAbility2, ASX_HeavyArmorHelmetMovementSpeedPenaltyAbility2, ASX_HeavyArmorHelmetMagickaRateMultPenaltyAbility2, ASX_HeavyArmorHelmetStaminaRateMultPenaltyAbility2),
            new ArmorActionSpells(ASX_HeavyArmorHelmetAttackSpeedPenaltyAbility3, ASX_HeavyArmorHelmetRangedSpeedPenaltyAbility3, ASX_HeavyArmorHelmetMovementSpeedPenaltyAbility3, ASX_HeavyArmorHelmetMagickaRateMultPenaltyAbility3, ASX_HeavyArmorHelmetStaminaRateMultPenaltyAbility3),
            new ArmorActionSpells(ASX_HeavyArmorHelmetAttackSpeedPenaltyAbility4, ASX_HeavyArmorHelmetRangedSpeedPenaltyAbility4, ASX_HeavyArmorHelmetMovementSpeedPenaltyAbility4, ASX_HeavyArmorHelmetMagickaRateMultPenaltyAbility4, ASX_HeavyArmorHelmetStaminaRateMultPenaltyAbility4)

        };
        static readonly List<ArmorActionSpells> HeavyShieldSpells = new()
        {
            new ArmorActionSpells(ASX_HeavyArmorShieldAttackSpeedPenaltyAbility1, null, ASX_HeavyArmorShieldMovementSpeedPenaltyAbility1, ASX_HeavyArmorShieldMagickaRateMultPenaltyAbility1, ASX_HeavyArmorShieldStaminaRateMultPenaltyAbility1),
            new ArmorActionSpells(ASX_HeavyArmorShieldAttackSpeedPenaltyAbility2, null, ASX_HeavyArmorShieldMovementSpeedPenaltyAbility2, ASX_HeavyArmorShieldMagickaRateMultPenaltyAbility2, ASX_HeavyArmorShieldStaminaRateMultPenaltyAbility2),
            new ArmorActionSpells(ASX_HeavyArmorShieldAttackSpeedPenaltyAbility3, null, ASX_HeavyArmorShieldMovementSpeedPenaltyAbility3, ASX_HeavyArmorShieldMagickaRateMultPenaltyAbility3, ASX_HeavyArmorShieldStaminaRateMultPenaltyAbility3),
            new ArmorActionSpells(ASX_HeavyArmorShieldAttackSpeedPenaltyAbility4, null, ASX_HeavyArmorShieldMovementSpeedPenaltyAbility4, ASX_HeavyArmorShieldMagickaRateMultPenaltyAbility4, ASX_HeavyArmorShieldStaminaRateMultPenaltyAbility4)

        };

        public static readonly Dictionary<string, List<ArmorActionSpells>> LightArmorActionSpellCollection = new()
        {
            { "Boots", LightBootSpells },
            { "Cuirass", LightCuirassSpells },
            { "Gauntlets", LightGauntletsSpells },
            { "Helmet", LightHelmetSpells },
            { "Shield", LightShieldSpells }
        };
        public static readonly Dictionary<string, List<ArmorActionSpells>> HeavyArmorActionSpellCollection = new()
        {
            { "Boots", HeavyBootSpells },
            { "Cuirass", HeavyCuirassSpells },
            { "Gauntlets", HeavyGauntletsSpells },
            { "Helmet", HeavyHelmetSpells },
            { "Shield", HeavyShieldSpells }
        };

        /*
        static readonly List<FormLink<IKeywordGetter> > mediumBoots     = new() { ASX_MediumArmorBootsT1, ASX_MediumArmorBootsT2, ASX_MediumArmorBootsT3, ASX_MediumArmorBootsT4 };
        static readonly List<FormLink<IKeywordGetter> > mediumCuirass   = new() { ASX_MediumArmorCuirassT1, ASX_MediumArmorCuirassT2, ASX_MediumArmorCuirassT3, ASX_MediumArmorCuirassT4 };
        static readonly List<FormLink<IKeywordGetter> > mediumGauntlets = new() { ASX_MediumArmorGauntletsT1, ASX_MediumArmorGauntletsT2, ASX_MediumArmorGauntletsT3, ASX_MediumArmorGauntletsT4 };
        static readonly List<FormLink<IKeywordGetter> > mediumHelmet    = new() { ASX_MediumArmorHelmetT1, ASX_MediumArmorHelmetT2, ASX_MediumArmorHelmetT3, ASX_MediumArmorHelmetT4 };
        static readonly List<FormLink<IKeywordGetter> > mediumShield    = new() { ASX_MediumArmorShieldT1, ASX_MediumArmorShieldT2, ASX_MediumArmorShieldT3, ASX_MediumArmorShieldT4 };

        */
    }
}