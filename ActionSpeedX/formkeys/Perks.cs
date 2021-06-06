using System.Collections.Generic;
using Mutagen.Bethesda;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.FormKeys.SkyrimSE;

namespace ActionSpeedX
{
    public static partial class FormKeys
    {
        public static class ActionSpeedXPerks
        {
            private static readonly ModKey ModKey = ModKey.FromNameAndExtension("ActionSpeedX.esp");

            // Power attacks
            private static FormLink<IPerkGetter> ASX_LightArmorGauntletsPowerAttackPenaltyPerk    => ModKey.MakeFormKey(0x002348);
            private static FormLink<IPerkGetter> ASX_LightArmorHelmetPowerAttackPenaltyPerk       => ModKey.MakeFormKey(0x00234A);
            private static FormLink<IPerkGetter> ASX_LightArmorBootsPowerAttackPenaltyPerk        => ModKey.MakeFormKey(0x00234B);
            private static FormLink<IPerkGetter> ASX_LightArmorShieldPowerAttackPenaltyPerk       => ModKey.MakeFormKey(0x00234C);
            private static FormLink<IPerkGetter> ASX_LightArmorCuirassPowerAttackPenaltyPerk      => ModKey.MakeFormKey(0x00234D);
            private static FormLink<IPerkGetter> ASX_HeavyArmorBootsPowerAttackPenaltyPerk        => ModKey.MakeFormKey(0x00339F);
            private static FormLink<IPerkGetter> ASX_HeavyArmorCuirassPowerAttackPenaltyPerk      => ModKey.MakeFormKey(0x0033A0);
            private static FormLink<IPerkGetter> ASX_HeavyArmorGauntletsPowerAttackPenaltyPerk    => ModKey.MakeFormKey(0x0033A1);
            private static FormLink<IPerkGetter> ASX_HeavyArmorHelmetPowerAttackPenaltyPerk       => ModKey.MakeFormKey(0x0033A2);
            private static FormLink<IPerkGetter> ASX_HeavyArmorShieldPowerAttackPenaltyPerk       => ModKey.MakeFormKey(0x0033A3);
            private static FormLink<IPerkGetter> ASX_TwoHandedPowerAttackStaminaCostReductionPerk => ModKey.MakeFormKey(0x0028B9);
            private static FormLink<IPerkGetter> ASX_OneHandedPowerAttackStaminaCostReductionPerk => ModKey.MakeFormKey(0x0028BA);

            // Spell Costs
            private static FormLink<IPerkGetter> ASX_LightArmorShieldSpellCostPenaltyPerk    => ModKey.MakeFormKey(0x00234E);
            private static FormLink<IPerkGetter> ASX_LightArmorBootsSpellCostPenaltyPerk     => ModKey.MakeFormKey(0x00234F);
            private static FormLink<IPerkGetter> ASX_LightArmorGauntletsSpellCostPenaltyPerk => ModKey.MakeFormKey(0x002350);
            private static FormLink<IPerkGetter> ASX_LightArmorHelmetSpellCostPenaltyPerk    => ModKey.MakeFormKey(0x002351);
            private static FormLink<IPerkGetter> ASX_LightArmorCuirassSpellCostPenaltyPerk   => ModKey.MakeFormKey(0x002352);
            private static FormLink<IPerkGetter> ASX_HeavyArmorBootsSpellCostPenaltyPerk     => ModKey.MakeFormKey(0x0033A4);
            private static FormLink<IPerkGetter> ASX_HeavyArmorShieldSpellCostPenaltyPerk    => ModKey.MakeFormKey(0x0033A5);
            private static FormLink<IPerkGetter> ASX_HeavyArmorCuirassSpellCostPenaltyPerk   => ModKey.MakeFormKey(0x0033A6);
            private static FormLink<IPerkGetter> ASX_HeavyArmorGauntletsSpellCostPenaltyPerk => ModKey.MakeFormKey(0x0033A7);
            private static FormLink<IPerkGetter> ASX_HeavyArmorHelmetSpellCostPenaltyPerk    => ModKey.MakeFormKey(0x0033A8);
            private static FormLink<IPerkGetter> ASX_DestructionSpellCostReductionPerk       => ModKey.MakeFormKey(0x002353);
            private static FormLink<IPerkGetter> ASX_AlterationSpellCostReductionPerk        => ModKey.MakeFormKey(0x002354);
            private static FormLink<IPerkGetter> ASX_IllusionSpellCostReductionPerk          => ModKey.MakeFormKey(0x002355);
            private static FormLink<IPerkGetter> ASX_ConjurationSpellCostReductionPerk       => ModKey.MakeFormKey(0x002356);
            private static FormLink<IPerkGetter> ASX_RestorationSpellCostReductionPerk       => ModKey.MakeFormKey(0x002357);

            // Move Speed
            private static FormLink<IPerkGetter> ASX_ArmorSpeedMasteryPerk            => ModKey.MakeFormKey(0x0064A4);
            private static FormLink<IPerkGetter> ASX_LightArmorMoveSpeedPenaltiesPerk => ModKey.MakeFormKey(0x002E39);
            private static FormLink<IPerkGetter> ASX_HeavyArmorMoveSpeedPenaltiesPerk => ModKey.MakeFormKey(0x003938);

            // Attack Speed
            private static FormLink<IPerkGetter> ASX_OneHandedAttackSpeedBuffPerk       => ModKey.MakeFormKey(0x002E30);
            private static FormLink<IPerkGetter> ASX_TwoHandedAttackSpeedBuffPerk       => ModKey.MakeFormKey(0x002E31);
            private static FormLink<IPerkGetter> ASX_HeavyArmorAttackSpeedPenaltiesPerk => ModKey.MakeFormKey(0x003943);
            private static FormLink<IPerkGetter> ASX_LightArmorAttackSpeedPenaltiesPerk => ModKey.MakeFormKey(0x002E3A);

            // Magicka Regeneration
            private static FormLink<IPerkGetter> ASX_HeavyArmorMagickaRegenPenaltiesPerk => ModKey.MakeFormKey(0x0033C0);
            private static FormLink<IPerkGetter> ASX_LightArmorMagickaRegenPenaltiesPerk => ModKey.MakeFormKey(0x002E3C);
            private static FormLink<IPerkGetter> ASX_DestructionMagickaRegenPerk         => ModKey.MakeFormKey(0x002E32);
            private static FormLink<IPerkGetter> ASX_AlterationMagickaRegenPerk          => ModKey.MakeFormKey(0x002E33);
            private static FormLink<IPerkGetter> ASX_IllusionMagickaRegenPerk            => ModKey.MakeFormKey(0x002E34);
            private static FormLink<IPerkGetter> ASX_ConjurationMagickaRegenPerk         => ModKey.MakeFormKey(0x002E35);
            private static FormLink<IPerkGetter> ASX_RestorationMagickaRegenPerk         => ModKey.MakeFormKey(0x002E36);

            // Stamina Regeneration
            private static FormLink<IPerkGetter> ASX_LightArmorStaminaRateMultBoostPerk  => ModKey.MakeFormKey(0x002E37);
            private static FormLink<IPerkGetter> ASX_LightArmorStaminaRegenPenaltiesPerk => ModKey.MakeFormKey(0x002E3D);
            private static FormLink<IPerkGetter> ASX_HeavyArmorStaminaRateMultBoostPerk  => ModKey.MakeFormKey(0x0033AA);
            private static FormLink<IPerkGetter> ASX_HeavyArmorStaminaRegenPenaltiesPerk => ModKey.MakeFormKey(0x0033B5);

            // Ranged attack speed
            private static FormLink<IPerkGetter> ASX_HeavyArmorRangedAttackSpeedPenaltiesPerk => ModKey.MakeFormKey(0x0033C9);
            private static FormLink<IPerkGetter> ASX_RangedAttackSpeedBoostPerk               => ModKey.MakeFormKey(0x002E38);
            private static FormLink<IPerkGetter> ASX_LightArmorRangedAttackSpeedPenaltiesPerk => ModKey.MakeFormKey(0x002E3B);

            //racials

            private static FormLink<IPerkGetter> ASX_OrcRacialProficiencyPerk      => ModKey.MakeFormKey(0x007A63);
            private static FormLink<IPerkGetter> ASX_NordRacialProficiencyPerk     => ModKey.MakeFormKey(0x007A65);
            private static FormLink<IPerkGetter> ASX_BosmerRacialProficiencyPerk   => ModKey.MakeFormKey(0x007A66);
            private static FormLink<IPerkGetter> ASX_DunmerRacialProficiencyPerk   => ModKey.MakeFormKey(0x007A67);
            private static FormLink<IPerkGetter> ASX_ImperialRacialProficiencyPerk => ModKey.MakeFormKey(0x007A68);
            private static FormLink<IPerkGetter> ASX_RedguardRacialProficiencyPerk => ModKey.MakeFormKey(0x007A69);
            private static FormLink<IPerkGetter> ASX_ArgonianRacialProficiencyPerk => ModKey.MakeFormKey(0x007A6A);

            //factions
            private static FormLink<IPerkGetter> ASX_DawnguardFactionProficiencyPerk       => ModKey.MakeFormKey(0x007A6B);
            private static FormLink<IPerkGetter> ASX_ImperialSoldierFactionProficiencyPerk => ModKey.MakeFormKey(0x007A6C);
            private static FormLink<IPerkGetter> ASX_ThalmorFactionProficiencyPerk         => ModKey.MakeFormKey(0x007A6D);
            private static FormLink<IPerkGetter> ASX_StormcloakFactionProficiencyPerk      => ModKey.MakeFormKey(0x007A6E);
            private static FormLink<IPerkGetter> ASX_GuardsFactionProficiencyPerk          => ModKey.MakeFormKey(0x007A6F);
            private static FormLink<IPerkGetter> ASX_ForswornFactionProficiencyPerk        => ModKey.MakeFormKey(0x007A70);
            private static FormLink<IPerkGetter> ASX_FalmerFactionProficiencyPerk          => ModKey.MakeFormKey(0x007A71);
            private static FormLink<IPerkGetter> ASX_DraugrFactionProficiencyPerk          => ModKey.MakeFormKey(0x007A72);
            private static FormLink<IPerkGetter> ASX_DremoraFactionProficiencyPerk         => ModKey.MakeFormKey(0x007A73);

            /* If the user distributes racial perks, add the dummy perk to the Player ref. A quest/script runs once after character creation that
			  checks if the player has the dummy perk. If so it will add the approrpriate racial perk to them.
			*/
            public static FormLink<IPerkGetter> ASX_DummyPerk => ModKey.MakeFormKey(0x008A98);

            /**
             * Group perks into lists so we can combine what we need to distribute by checking which settings were enabled. 
             */

            public static readonly List<FormLink<IPerkGetter>> PowerAttacks = new(){
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

            public static readonly List<FormLink<IPerkGetter>> SpellCosts = new() {
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

            public static readonly List<FormLink<IPerkGetter>> MoveSpeed = new() {
                ASX_LightArmorMoveSpeedPenaltiesPerk,
                ASX_ArmorSpeedMasteryPerk,
                ASX_HeavyArmorMoveSpeedPenaltiesPerk
            };

            public static readonly List<FormLink<IPerkGetter>> AttackSpeed = new() {
                ASX_LightArmorAttackSpeedPenaltiesPerk,
                ASX_HeavyArmorAttackSpeedPenaltiesPerk,
                ASX_OneHandedAttackSpeedBuffPerk,
                ASX_TwoHandedAttackSpeedBuffPerk
            };

            public static readonly List<FormLink<IPerkGetter>> MagickaRegen = new() {
                ASX_LightArmorMagickaRegenPenaltiesPerk,
                ASX_HeavyArmorMagickaRegenPenaltiesPerk,
                ASX_AlterationMagickaRegenPerk,
                ASX_ConjurationMagickaRegenPerk,
                ASX_DestructionMagickaRegenPerk,
                ASX_IllusionMagickaRegenPerk,
                ASX_RestorationMagickaRegenPerk
            };

            public static readonly List<FormLink<IPerkGetter>> StaminaRegen = new() {
                ASX_LightArmorStaminaRegenPenaltiesPerk,
                ASX_LightArmorStaminaRateMultBoostPerk,
                ASX_HeavyArmorStaminaRegenPenaltiesPerk,
                ASX_HeavyArmorStaminaRateMultBoostPerk
            };

            public static readonly List<FormLink<IPerkGetter>> RangedSpeed = new() {
                ASX_LightArmorRangedAttackSpeedPenaltiesPerk,
                ASX_HeavyArmorRangedAttackSpeedPenaltiesPerk,
                ASX_RangedAttackSpeedBoostPerk
            };

            // distribute by matching against RACE editor id. This is what needs to be updated for custom race proficiency perk support
            public static readonly Dictionary<string, FormLink<IPerkGetter>> RacialPerks = new () {
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
            public static readonly Dictionary<string, FormLink<IPerkGetter>> FactionPerks = new() {
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
            private static FormLink<IPerkGetter> ASX_MediumArmorBootsPowerAttackPenaltyPerk     => ModKey.MakeFormKey(0x003EBA);
            private static FormLink<IPerkGetter> ASX_MediumArmorShieldPowerAttackPenaltyPerk    => ModKey.MakeFormKey(0x003EBB);
            private static FormLink<IPerkGetter> ASX_MediumArmorGauntletsPowerAttackPenaltyPerk => ModKey.MakeFormKey(0x003EBC);
            private static FormLink<IPerkGetter> ASX_MediumArmorHelmetPowerAttackPenaltyPerk    => ModKey.MakeFormKey(0x003EBD);
            private static FormLink<IPerkGetter> ASX_MediumArmorCuirassPowerAttackPenaltyPerk   => ModKey.MakeFormKey(0x003EBE);
            private static FormLink<IPerkGetter> ASX_MediumArmorBootsSpellCostPenaltyPerk       => ModKey.MakeFormKey(0x003EBF);
            private static FormLink<IPerkGetter> ASX_MediumArmorShieldSpellCostPenaltyPerk      => ModKey.MakeFormKey(0x003EC0);
            private static FormLink<IPerkGetter> ASX_MediumArmorGauntletsSpellCostPenaltyPerk   => ModKey.MakeFormKey(0x003EC1);
            private static FormLink<IPerkGetter> ASX_MediumArmorHelmetSpellCostPenaltyPerk      => ModKey.MakeFormKey(0x003EC2);
            private static FormLink<IPerkGetter> ASX_MediumArmorCuirassSpellCostPenaltyPerk     => ModKey.MakeFormKey(0x003EC3);
            private static FormLink<IPerkGetter> ASX_MediumArmorMoveSpeedPenaltiesPerk          => ModKey.MakeFormKey(0x004430);
            private static FormLink<IPerkGetter> ASX_MediumArmorAttackSpeedPenaltiesPerk        => ModKey.MakeFormKey(0x004432);
            private static FormLink<IPerkGetter> ASX_MediumArmorRangedAttackSpeedPenaltiesPerk  => ModKey.MakeFormKey(0x004444);
            private static FormLink<IPerkGetter> ASX_MediumArmorMagickaRegenPenaltiesPerk       => ModKey.MakeFormKey(0x0049B0);
            private static FormLink<IPerkGetter> ASX_MediumArmorStaminaRegenPenaltiesPerk       => ModKey.MakeFormKey(0x0049BB);
            */


        }

        /// <summary>
        /// This contains a perk records form id, ability(spell) to append, and description update(if any)
        ///
        /// </summary>
        public class PerkModifier
        {
            public FormLink<ISpellGetter> SpellForm; // Ability id
            public FormLink<IPerkGetter> PerkForm; // Perk id
            public string Description; // Appends text to Perk

            public PerkModifier(FormLink<IPerkGetter> perkForm, FormLink<ISpellGetter> spellForm, string dsecription)
            {
                this.SpellForm   = spellForm;
                this.PerkForm    = perkForm;
                this.Description = dsecription;
            }
        }

        public static class AdamantPerks
        {
            //private static readonly ModKey ModKey = ModKey.FromNameAndExtension("Adamant.esp");

            // Power attacks
            private static FormLink<IPerkGetter> MAG_Philosopher00  => Skyrim.Perk.AlterationNovice00;
            private static FormLink<IPerkGetter> MAG_Summoner00     => Skyrim.Perk.ConjurationNovice00;
            private static FormLink<IPerkGetter> MAG_Elementalist00 => Skyrim.Perk.DestructionNovice00;
            private static FormLink<IPerkGetter> MAG_Illusionist00  => Skyrim.Perk.IllusionNovice00;
            private static FormLink<IPerkGetter> MAG_Healer00       => Skyrim.Perk.RestorationNovice00;

            private static FormLink<IPerkGetter> MAG_Marksman00 => Skyrim.Perk.Overdraw00;
            private static FormLink<IPerkGetter> MAG_Juggernaut00 => Skyrim.Perk.Juggernaut00;
            private static FormLink<IPerkGetter> MAG_Scout00 => Skyrim.Perk.AgileDefender00;
            private static FormLink<IPerkGetter> MAG_Skirmisher00 => Skyrim.Perk.Armsman00;
            private static FormLink<IPerkGetter> MAG_Barbarian00 => Skyrim.Perk.Barbarian00;

            /*
             * MAG_Philosopher00 Alteration
			 MAG_Summoner00 Conjur
			 MAG_Elementalist00 Destruction
			 MAG_Illusionist00
			 MAG_Healer00
			 
			 
			 MAG_Juggernaut00 heavy-armor
			 MAG_Scout00 light-armor
			 
			 MAG_Skirmisher00 one-handed
			 MAG_Barbarian00 two-handed
			
			
			MAG_Marksman00 Archery
             */
        }

        public static class OrdinatorPerks
        {
            private static readonly ModKey ModKey = ModKey.FromNameAndExtension("Ordinator - Perks of Skyrim.esp");

            // Power attacks
            private static FormLink<IPerkGetter> ORD_Alt00_AlterationMastery_Perk_00  => ModKey.MakeFormKey(0x0148ff); 
            private static FormLink<IPerkGetter> ORD_Con00_ConjurationMastery_Perk_00 => ModKey.MakeFormKey(0x014900); 
            private static FormLink<IPerkGetter> ORD_Des00_DestructionMastery_Perk_00 => ModKey.MakeFormKey(0X0148FD); 
            private static FormLink<IPerkGetter> ORD_Ill00_IllusionMastery_Perk_00    => ModKey.MakeFormKey(0X0148FE);
            private static FormLink<IPerkGetter> ORD_Res00_RestorationMastery_Perk_00 => ModKey.MakeFormKey(0X014357);
            private static FormLink<IPerkGetter> ORD_Arc00_ArcheryMastery_Perk_00     => ModKey.MakeFormKey(0x00ABE1);
            private static FormLink<IPerkGetter> ORD_Hea00_HeavyArmorMastery_Perk_00  => ModKey.MakeFormKey(0x007AB2);
            private static FormLink<IPerkGetter> ORD_Lia00_LightArmorMastery_Perk_00  => ModKey.MakeFormKey(0x007AB0);
            private static FormLink<IPerkGetter> ORD_One00_OneHandedMastery_Perk_00   => ModKey.MakeFormKey(0x00B149);
            private static FormLink<IPerkGetter> ORD_Two00_TwoHandedMastery_Perk_00   => ModKey.MakeFormKey(0x00B14B);


            /*
             * (ORD_Alt00_AlterationMastery_Perk_00,
			 ORD_Con00_ConjurationMastery_Perk_00,
			 ORD_Des00_DestructionMastery_Perk_00,
			 ORD_Ill00_IllusionMastery_Perk_00,
			 ORD_Res00_RestorationMastery_Perk_00
			 
			 ORD_Arc00_ArcheryMastery_Perk_00,
			 ORD_Hea00_HeavyArmorMastery_Perk_00, ORD_HeaNPC_HeavyArmorMastery_Perk_00_WasJuggernaut_OrdASISExclude 
			 ORD_Lia00_LightArmorMastery_Perk_00, ORD_LiaNPC_LightArmorMastery_Perk_00_WasAgileDefender_OrdASISExclude
			 ORD_One00_OneHandedMastery_Perk_00
			 ORD_Two00_TwoHandedMastery_Perk_00
             */
        }

        public static class VokriiPerks
        {
            //private static readonly ModKey ModKey = ModKey.FromNameAndExtension("Vokrii - Minimalistic Perks of Skyrim.esp");

            // Power attacks
            private static FormLink<IPerkGetter> VKR_Alt_000_AlterationMastery_Perk_WasAlteration1    => Skyrim.Perk.AlterationNovice00;
            private static FormLink<IPerkGetter> VKR_Con_000_ConjurationMastery_Perk_WasConjuration1  => Skyrim.Perk.ConjurationNovice00;
            private static FormLink<IPerkGetter> VKR_Des_000_DestructionMastery_Perk_WasDestruction1  => Skyrim.Perk.DestructionNovice00;
            private static FormLink<IPerkGetter> VKR_Ill_000_IllusionMastery_Perk_WasIllusion1        => Skyrim.Perk.IllusionNovice00;
            private static FormLink<IPerkGetter> VKR_Res_000_RestorationMastery_Perk_WasRestoration1  => Skyrim.Perk.RestorationNovice00;
            private static FormLink<IPerkGetter> VKR_Arc_000_ArcheryMastery_Perk_WasOverdraw1         => Skyrim.Perk.Overdraw00;
            private static FormLink<IPerkGetter> VKR_Hea_000_HeavyArmorMastery_Perk_WasJuggernaut1    => Skyrim.Perk.Juggernaut00;
            private static FormLink<IPerkGetter> VKR_Lia_000_LightArmorMastery_Perk_WasAgileDefender1 => Skyrim.Perk.AgileDefender00;
            private static FormLink<IPerkGetter> VKR_One_000_OneHandedMastery_Perk_WasArmsman1        => Skyrim.Perk.Armsman00;
            private static FormLink<IPerkGetter> VKR_Two_000_TwoHandedMastery_Perk_WasBarbarian1      => Skyrim.Perk.Barbarian00;







            /*
             * (VKR_Alt_000_AlterationMastery_Perk_WasAlteration1, 
			 VKR_Con_000_ConjurationMastery_Perk_WasConjuration1, 
			 VKR_Des_000_DestructionMastery_Perk_WasDestruction1, 
			 VKR_Ill_000_IllusionMastery_Perk_WasIllusion1, 
			 VKR_Res_000_RestorationMastery_Perk_WasRestoration1
			 VKR_Arc_000_ArcheryMastery_Perk_WasOverdraw1, 
			 VKR_Hea_000_HeavyArmorMastery_Perk_WasJuggernaut1
			 VKR_Lia_000_LightArmorMastery_Perk_WasAgileDefender1
			 VKR_One_000_OneHandedMastery_Perk_WasArmsman1
             */
        }
    }
}