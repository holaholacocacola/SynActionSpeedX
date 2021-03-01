using System.Collections.Generic;
using Mutagen.Bethesda;

namespace ActionSpeedX
{
    public static partial class FormKeys
    {
        public static class Perks
        {
            private static readonly ModKey ModKey = ModKey.FromNameAndExtension("ActionSpeedX.esp");

            // Power attacks
            private static FormKey ASX_LightArmorGauntletsPowerAttackPenaltyPerk => ModKey.MakeFormKey(0x002348);
            private static FormKey ASX_LightArmorHelmetPowerAttackPenaltyPerk => ModKey.MakeFormKey(0x00234A);
            private static FormKey ASX_LightArmorBootsPowerAttackPenaltyPerk => ModKey.MakeFormKey(0x00234B);
            private static FormKey ASX_LightArmorShieldPowerAttackPenaltyPerk => ModKey.MakeFormKey(0x00234C);
            private static FormKey ASX_LightArmorCuirassPowerAttackPenaltyPerk => ModKey.MakeFormKey(0x00234D);
            private static FormKey ASX_HeavyArmorBootsPowerAttackPenaltyPerk => ModKey.MakeFormKey(0x00339F);
            private static FormKey ASX_HeavyArmorCuirassPowerAttackPenaltyPerk => ModKey.MakeFormKey(0x0033A0);
            private static FormKey ASX_HeavyArmorGauntletsPowerAttackPenaltyPerk => ModKey.MakeFormKey(0x0033A1);
            private static FormKey ASX_HeavyArmorHelmetPowerAttackPenaltyPerk => ModKey.MakeFormKey(0x0033A2);
            private static FormKey ASX_HeavyArmorShieldPowerAttackPenaltyPerk => ModKey.MakeFormKey(0x0033A3);
            private static FormKey ASX_TwoHandedPowerAttackStaminaCostReductionPerk => ModKey.MakeFormKey(0x0028B9);
            private static FormKey ASX_OneHandedPowerAttackStaminaCostReductionPerk => ModKey.MakeFormKey(0x0028BA);

            // Spell Costs
            private static FormKey ASX_LightArmorShieldSpellCostPenaltyPerk => ModKey.MakeFormKey(0x00234E);
            private static FormKey ASX_LightArmorBootsSpellCostPenaltyPerk => ModKey.MakeFormKey(0x00234F);
            private static FormKey ASX_LightArmorGauntletsSpellCostPenaltyPerk => ModKey.MakeFormKey(0x002350);
            private static FormKey ASX_LightArmorHelmetSpellCostPenaltyPerk => ModKey.MakeFormKey(0x002351);
            private static FormKey ASX_LightArmorCuirassSpellCostPenaltyPerk => ModKey.MakeFormKey(0x002352);
            private static FormKey ASX_HeavyArmorBootsSpellCostPenaltyPerk => ModKey.MakeFormKey(0x0033A4);
            private static FormKey ASX_HeavyArmorShieldSpellCostPenaltyPerk => ModKey.MakeFormKey(0x0033A5);
            private static FormKey ASX_HeavyArmorCuirassSpellCostPenaltyPerk => ModKey.MakeFormKey(0x0033A6);
            private static FormKey ASX_HeavyArmorGauntletsSpellCostPenaltyPerk => ModKey.MakeFormKey(0x0033A7);
            private static FormKey ASX_HeavyArmorHelmetSpellCostPenaltyPerk => ModKey.MakeFormKey(0x0033A8);
            private static FormKey ASX_DestructionSpellCostReductionPerk => ModKey.MakeFormKey(0x002353);
            private static FormKey ASX_AlterationSpellCostReductionPerk => ModKey.MakeFormKey(0x002354);
            private static FormKey ASX_IllusionSpellCostReductionPerk => ModKey.MakeFormKey(0x002355);
            private static FormKey ASX_ConjurationSpellCostReductionPerk => ModKey.MakeFormKey(0x002356);
            private static FormKey ASX_RestorationSpellCostReductionPerk => ModKey.MakeFormKey(0x002357);

            // Move Speed
            private static FormKey ASX_ArmorSpeedMasteryPerk => ModKey.MakeFormKey(0x0064A4);
            private static FormKey ASX_LightArmorMoveSpeedPenaltiesPerk => ModKey.MakeFormKey(0x002E39);
            private static FormKey ASX_HeavyArmorMoveSpeedPenaltiesPerk => ModKey.MakeFormKey(0x003938);

            // Attack Speed
            private static FormKey ASX_OneHandedAttackSpeedBuffPerk => ModKey.MakeFormKey(0x002E30);
            private static FormKey ASX_TwoHandedAttackSpeedBuffPerk => ModKey.MakeFormKey(0x002E31);
            private static FormKey ASX_HeavyArmorAttackSpeedPenaltiesPerk => ModKey.MakeFormKey(0x003943);
            private static FormKey ASX_LightArmorAttackSpeedPenaltiesPerk => ModKey.MakeFormKey(0x002E3A);

            // Magicka Regeneration
            private static FormKey ASX_HeavyArmorMagickaRegenPenaltiesPerk => ModKey.MakeFormKey(0x0033C0);
            private static FormKey ASX_LightArmorMagickaRegenPenaltiesPerk => ModKey.MakeFormKey(0x002E3C);
            private static FormKey ASX_DestructionMagickaRegenPerk => ModKey.MakeFormKey(0x002E32);
            private static FormKey ASX_AlterationMagickaRegenPerk => ModKey.MakeFormKey(0x002E33);
            private static FormKey ASX_IllusionMagickaRegenPerk => ModKey.MakeFormKey(0x002E34);
            private static FormKey ASX_ConjurationMagickaRegenPerk => ModKey.MakeFormKey(0x002E35);
            private static FormKey ASX_RestorationMagickaRegenPerk => ModKey.MakeFormKey(0x002E36);

            // Stamina Regeneration
            private static FormKey ASX_LightArmorStaminaRateMultBoostPerk => ModKey.MakeFormKey(0x002E37);
            private static FormKey ASX_LightArmorStaminaRegenPenaltiesPerk => ModKey.MakeFormKey(0x002E3D);
            private static FormKey ASX_HeavyArmorStaminaRateMultBoostPerk => ModKey.MakeFormKey(0x0033AA);
            private static FormKey ASX_HeavyArmorStaminaRegenPenaltiesPerk => ModKey.MakeFormKey(0x0033B5);

            // Ranged attack speed
            private static FormKey ASX_HeavyArmorRangedAttackSpeedPenaltiesPerk => ModKey.MakeFormKey(0x0033C9);
            private static FormKey ASX_RangedAttackSpeedBoostPerk => ModKey.MakeFormKey(0x002E38);
            private static FormKey ASX_LightArmorRangedAttackSpeedPenaltiesPerk => ModKey.MakeFormKey(0x002E3B);

            //racials

            private static FormKey ASX_OrcRacialProficiencyPerk => ModKey.MakeFormKey(0x007A63);
            private static FormKey ASX_NordRacialProficiencyPerk => ModKey.MakeFormKey(0x007A65);
            private static FormKey ASX_BosmerRacialProficiencyPerk => ModKey.MakeFormKey(0x007A66);
            private static FormKey ASX_DunmerRacialProficiencyPerk => ModKey.MakeFormKey(0x007A67);
            private static FormKey ASX_ImperialRacialProficiencyPerk => ModKey.MakeFormKey(0x007A68);
            private static FormKey ASX_RedguardRacialProficiencyPerk => ModKey.MakeFormKey(0x007A69);
            private static FormKey ASX_ArgonianRacialProficiencyPerk => ModKey.MakeFormKey(0x007A6A);

            //factions
            private static FormKey ASX_DawnguardFactionProficiencyPerk => ModKey.MakeFormKey(0x007A6B);
            private static FormKey ASX_ImperialSoldierFactionProficiencyPerk => ModKey.MakeFormKey(0x007A6C);
            private static FormKey ASX_ThalmorFactionProficiencyPerk => ModKey.MakeFormKey(0x007A6D);
            private static FormKey ASX_StormcloakFactionProficiencyPerk => ModKey.MakeFormKey(0x007A6E);
            private static FormKey ASX_GuardsFactionProficiencyPerk => ModKey.MakeFormKey(0x007A6F);
            private static FormKey ASX_ForswornFactionProficiencyPerk => ModKey.MakeFormKey(0x007A70);
            private static FormKey ASX_FalmerFactionProficiencyPerk => ModKey.MakeFormKey(0x007A71);
            private static FormKey ASX_DraugrFactionProficiencyPerk => ModKey.MakeFormKey(0x007A72);
            private static FormKey ASX_DremoraFactionProficiencyPerk => ModKey.MakeFormKey(0x007A73);

            /* If the user distributes racial perks, add the dummy perk to the Player ref. A quest/script runs once after character creation that
			  checks if the player has the dummy perk. If so it will add the approrpriate racial perk to them.
			*/
            public static FormKey ASX_DummyPerk => ModKey.MakeFormKey(0x008A98);

            /**
             * Group perks into lists so we can combine what we need to distribute by checking which settings were enabled. 
             */

            public static readonly List<FormKey> PowerAttacks = new List<FormKey> {
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

            public static readonly List<FormKey> SpellCosts = new List<FormKey>{
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

            public static readonly List<FormKey> MoveSpeed = new List<FormKey> {
                ASX_LightArmorMoveSpeedPenaltiesPerk,
                ASX_ArmorSpeedMasteryPerk,
                ASX_HeavyArmorMoveSpeedPenaltiesPerk
            };

            public static readonly List<FormKey> AttackSpeed = new List<FormKey> {
                ASX_LightArmorAttackSpeedPenaltiesPerk,
                ASX_HeavyArmorAttackSpeedPenaltiesPerk,
                ASX_OneHandedAttackSpeedBuffPerk,
                ASX_TwoHandedAttackSpeedBuffPerk
            };

            public static readonly List<FormKey> MagickaRegen = new List<FormKey> {
                ASX_LightArmorMagickaRegenPenaltiesPerk,
                ASX_HeavyArmorMagickaRegenPenaltiesPerk,
                ASX_AlterationMagickaRegenPerk,
                ASX_ConjurationMagickaRegenPerk,
                ASX_DestructionMagickaRegenPerk,
                ASX_IllusionMagickaRegenPerk,
                ASX_RestorationMagickaRegenPerk
            };

            public static readonly List<FormKey> StaminaRegen = new List<FormKey> {
                ASX_LightArmorStaminaRegenPenaltiesPerk,
                ASX_LightArmorStaminaRateMultBoostPerk,
                ASX_HeavyArmorStaminaRegenPenaltiesPerk,
                ASX_HeavyArmorStaminaRateMultBoostPerk
            };

            public static readonly List<FormKey> RangedSpeed = new List<FormKey> {
                ASX_LightArmorRangedAttackSpeedPenaltiesPerk,
                ASX_HeavyArmorRangedAttackSpeedPenaltiesPerk,
                ASX_RangedAttackSpeedBoostPerk
            };

            // distribute by matching against RACE editor id. This is what needs to be updated for custom race proficiency perk support
            public static readonly Dictionary<string, FormKey> RacialPerks = new Dictionary<string, FormKey>{
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
                { "WoodElfRaceVampire", ASX_BosmerRacialProficiencyPerk },
            };

            // These are distributed by looping through npc factions and matching against editorId.
            public static readonly Dictionary<string, FormKey> FactionPerks = new Dictionary<string, FormKey>
            {
                {"CWImperialFaction", ASX_ImperialSoldierFactionProficiencyPerk },
                {"CWSonsFaction", ASX_StormcloakFactionProficiencyPerk },
                //{"DraugrFaction", ASX_DraugrFactionProficiencyPerk },
              //  {"DremoraFaction", ASX_DremoraFactionProficiencyPerk },
             //   {"FalmerFaction", ASX_FalmerFactionProficiencyPerk },
                {"ForswornFaction", ASX_ForswornFactionProficiencyPerk },
                {"IsGuardFaction", ASX_GuardsFactionProficiencyPerk },
                {"DLC1HunterFaction", ASX_DawnguardFactionProficiencyPerk },
                {"ThalmorFaction", ASX_ThalmorFactionProficiencyPerk },
            };

            /* Will add once medium armor patcher is done
            private static FormKey ASX_MediumArmorBootsPowerAttackPenaltyPerk     => ModKey.MakeFormKey(0x003EBA);
            private static FormKey ASX_MediumArmorShieldPowerAttackPenaltyPerk    => ModKey.MakeFormKey(0x003EBB);
            private static FormKey ASX_MediumArmorGauntletsPowerAttackPenaltyPerk => ModKey.MakeFormKey(0x003EBC);
            private static FormKey ASX_MediumArmorHelmetPowerAttackPenaltyPerk    => ModKey.MakeFormKey(0x003EBD);
            private static FormKey ASX_MediumArmorCuirassPowerAttackPenaltyPerk   => ModKey.MakeFormKey(0x003EBE);
            private static FormKey ASX_MediumArmorBootsSpellCostPenaltyPerk       => ModKey.MakeFormKey(0x003EBF);
            private static FormKey ASX_MediumArmorShieldSpellCostPenaltyPerk      => ModKey.MakeFormKey(0x003EC0);
            private static FormKey ASX_MediumArmorGauntletsSpellCostPenaltyPerk   => ModKey.MakeFormKey(0x003EC1);
            private static FormKey ASX_MediumArmorHelmetSpellCostPenaltyPerk      => ModKey.MakeFormKey(0x003EC2);
            private static FormKey ASX_MediumArmorCuirassSpellCostPenaltyPerk     => ModKey.MakeFormKey(0x003EC3);
            private static FormKey ASX_MediumArmorMoveSpeedPenaltiesPerk          => ModKey.MakeFormKey(0x004430);
            private static FormKey ASX_MediumArmorAttackSpeedPenaltiesPerk        => ModKey.MakeFormKey(0x004432);
            private static FormKey ASX_MediumArmorRangedAttackSpeedPenaltiesPerk  => ModKey.MakeFormKey(0x004444);
            private static FormKey ASX_MediumArmorMagickaRegenPenaltiesPerk       => ModKey.MakeFormKey(0x0049B0);
            private static FormKey ASX_MediumArmorStaminaRegenPenaltiesPerk       => ModKey.MakeFormKey(0x0049BB);
            */


        }
    }
}