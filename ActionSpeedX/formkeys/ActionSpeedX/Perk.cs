using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Skyrim;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class ActionSpeedX_
    {

        public static class Perk
        {
            private static readonly ModKey ModKey = ModKey.FromNameAndExtension("ActionSpeedX.esp");

            // Power attacks
            public static FormLink<IPerkGetter> ASX_LightArmorGauntletsPowerAttackPenaltyPerk    => ModKey.MakeFormKey(0x002348);
            public static FormLink<IPerkGetter> ASX_LightArmorHelmetPowerAttackPenaltyPerk       => ModKey.MakeFormKey(0x00234A);
            public static FormLink<IPerkGetter> ASX_LightArmorBootsPowerAttackPenaltyPerk        => ModKey.MakeFormKey(0x00234B);
            public static FormLink<IPerkGetter> ASX_LightArmorShieldPowerAttackPenaltyPerk       => ModKey.MakeFormKey(0x00234C);
            public static FormLink<IPerkGetter> ASX_LightArmorCuirassPowerAttackPenaltyPerk      => ModKey.MakeFormKey(0x00234D);
            public static FormLink<IPerkGetter> ASX_HeavyArmorBootsPowerAttackPenaltyPerk        => ModKey.MakeFormKey(0x00339F);
            public static FormLink<IPerkGetter> ASX_HeavyArmorCuirassPowerAttackPenaltyPerk      => ModKey.MakeFormKey(0x0033A0);
            public static FormLink<IPerkGetter> ASX_HeavyArmorGauntletsPowerAttackPenaltyPerk    => ModKey.MakeFormKey(0x0033A1);
            public static FormLink<IPerkGetter> ASX_HeavyArmorHelmetPowerAttackPenaltyPerk       => ModKey.MakeFormKey(0x0033A2);
            public static FormLink<IPerkGetter> ASX_HeavyArmorShieldPowerAttackPenaltyPerk       => ModKey.MakeFormKey(0x0033A3);
            public static FormLink<IPerkGetter> ASX_TwoHandedPowerAttackStaminaCostReductionPerk => ModKey.MakeFormKey(0x0028B9);
            public static FormLink<IPerkGetter> ASX_OneHandedPowerAttackStaminaCostReductionPerk => ModKey.MakeFormKey(0x0028BA);

            // Spell Costs
            public static FormLink<IPerkGetter> ASX_LightArmorShieldSpellCostPenaltyPerk    => ModKey.MakeFormKey(0x00234E);
            public static FormLink<IPerkGetter> ASX_LightArmorBootsSpellCostPenaltyPerk     => ModKey.MakeFormKey(0x00234F);
            public static FormLink<IPerkGetter> ASX_LightArmorGauntletsSpellCostPenaltyPerk => ModKey.MakeFormKey(0x002350);
            public static FormLink<IPerkGetter> ASX_LightArmorHelmetSpellCostPenaltyPerk    => ModKey.MakeFormKey(0x002351);
            public static FormLink<IPerkGetter> ASX_LightArmorCuirassSpellCostPenaltyPerk   => ModKey.MakeFormKey(0x002352);
            public static FormLink<IPerkGetter> ASX_HeavyArmorBootsSpellCostPenaltyPerk     => ModKey.MakeFormKey(0x0033A4);
            public static FormLink<IPerkGetter> ASX_HeavyArmorShieldSpellCostPenaltyPerk    => ModKey.MakeFormKey(0x0033A5);
            public static FormLink<IPerkGetter> ASX_HeavyArmorCuirassSpellCostPenaltyPerk   => ModKey.MakeFormKey(0x0033A6);
            public static FormLink<IPerkGetter> ASX_HeavyArmorGauntletsSpellCostPenaltyPerk => ModKey.MakeFormKey(0x0033A7);
            public static FormLink<IPerkGetter> ASX_HeavyArmorHelmetSpellCostPenaltyPerk    => ModKey.MakeFormKey(0x0033A8);
            public static FormLink<IPerkGetter> ASX_DestructionSpellCostReductionPerk       => ModKey.MakeFormKey(0x002353);
            public static FormLink<IPerkGetter> ASX_AlterationSpellCostReductionPerk        => ModKey.MakeFormKey(0x002354);
            public static FormLink<IPerkGetter> ASX_IllusionSpellCostReductionPerk          => ModKey.MakeFormKey(0x002355);
            public static FormLink<IPerkGetter> ASX_ConjurationSpellCostReductionPerk       => ModKey.MakeFormKey(0x002356);
            public static FormLink<IPerkGetter> ASX_RestorationSpellCostReductionPerk       => ModKey.MakeFormKey(0x002357);

            // Move Speed
            public static FormLink<IPerkGetter> ASX_ArmorSpeedMasteryPerk            => ModKey.MakeFormKey(0x0064A4);
            public static FormLink<IPerkGetter> ASX_LightArmorMoveSpeedPenaltiesPerk => ModKey.MakeFormKey(0x002E39);
            public static FormLink<IPerkGetter> ASX_HeavyArmorMoveSpeedPenaltiesPerk => ModKey.MakeFormKey(0x003938);

            // Attack Speed
            public static FormLink<IPerkGetter> ASX_OneHandedAttackSpeedBuffPerk       => ModKey.MakeFormKey(0x002E30);
            public static FormLink<IPerkGetter> ASX_TwoHandedAttackSpeedBuffPerk       => ModKey.MakeFormKey(0x002E31);
            public static FormLink<IPerkGetter> ASX_HeavyArmorAttackSpeedPenaltiesPerk => ModKey.MakeFormKey(0x003943);
            public static FormLink<IPerkGetter> ASX_LightArmorAttackSpeedPenaltiesPerk => ModKey.MakeFormKey(0x002E3A);

            // Magicka Regeneration
            public static FormLink<IPerkGetter> ASX_HeavyArmorMagickaRegenPenaltiesPerk => ModKey.MakeFormKey(0x0033C0);
            public static FormLink<IPerkGetter> ASX_LightArmorMagickaRegenPenaltiesPerk => ModKey.MakeFormKey(0x002E3C);
            public static FormLink<IPerkGetter> ASX_DestructionMagickaRegenPerk         => ModKey.MakeFormKey(0x002E32);
            public static FormLink<IPerkGetter> ASX_AlterationMagickaRegenPerk          => ModKey.MakeFormKey(0x002E33);
            public static FormLink<IPerkGetter> ASX_IllusionMagickaRegenPerk            => ModKey.MakeFormKey(0x002E34);
            public static FormLink<IPerkGetter> ASX_ConjurationMagickaRegenPerk         => ModKey.MakeFormKey(0x002E35);
            public static FormLink<IPerkGetter> ASX_RestorationMagickaRegenPerk         => ModKey.MakeFormKey(0x002E36);

            // Stamina Regeneration
            public static FormLink<IPerkGetter> ASX_LightArmorStaminaRateMultBoostPerk  => ModKey.MakeFormKey(0x002E37);
            public static FormLink<IPerkGetter> ASX_LightArmorStaminaRegenPenaltiesPerk => ModKey.MakeFormKey(0x002E3D);
            public static FormLink<IPerkGetter> ASX_HeavyArmorStaminaRateMultBoostPerk  => ModKey.MakeFormKey(0x0033AA);
            public static FormLink<IPerkGetter> ASX_HeavyArmorStaminaRegenPenaltiesPerk => ModKey.MakeFormKey(0x0033B5);

            // Ranged attack speed
            public static FormLink<IPerkGetter> ASX_HeavyArmorRangedAttackSpeedPenaltiesPerk => ModKey.MakeFormKey(0x0033C9);
            public static FormLink<IPerkGetter> ASX_RangedAttackSpeedBoostPerk               => ModKey.MakeFormKey(0x002E38);
            public static FormLink<IPerkGetter> ASX_LightArmorRangedAttackSpeedPenaltiesPerk => ModKey.MakeFormKey(0x002E3B);

            //racials

            public static FormLink<IPerkGetter> ASX_OrcRacialProficiencyPerk      => ModKey.MakeFormKey(0x007A63);
            public static FormLink<IPerkGetter> ASX_NordRacialProficiencyPerk     => ModKey.MakeFormKey(0x007A65);
            public static FormLink<IPerkGetter> ASX_BosmerRacialProficiencyPerk   => ModKey.MakeFormKey(0x007A66);
            public static FormLink<IPerkGetter> ASX_DunmerRacialProficiencyPerk   => ModKey.MakeFormKey(0x007A67);
            public static FormLink<IPerkGetter> ASX_ImperialRacialProficiencyPerk => ModKey.MakeFormKey(0x007A68);
            public static FormLink<IPerkGetter> ASX_RedguardRacialProficiencyPerk => ModKey.MakeFormKey(0x007A69);
            public static FormLink<IPerkGetter> ASX_ArgonianRacialProficiencyPerk => ModKey.MakeFormKey(0x007A6A);

            //factions
            public static FormLink<IPerkGetter> ASX_DawnguardFactionProficiencyPerk       => ModKey.MakeFormKey(0x007A6B);
            public static FormLink<IPerkGetter> ASX_ImperialSoldierFactionProficiencyPerk => ModKey.MakeFormKey(0x007A6C);
            public static FormLink<IPerkGetter> ASX_ThalmorFactionProficiencyPerk         => ModKey.MakeFormKey(0x007A6D);
            public static FormLink<IPerkGetter> ASX_StormcloakFactionProficiencyPerk      => ModKey.MakeFormKey(0x007A6E);
            public static FormLink<IPerkGetter> ASX_GuardsFactionProficiencyPerk          => ModKey.MakeFormKey(0x007A6F);
            public static FormLink<IPerkGetter> ASX_ForswornFactionProficiencyPerk        => ModKey.MakeFormKey(0x007A70);
            public static FormLink<IPerkGetter> ASX_FalmerFactionProficiencyPerk          => ModKey.MakeFormKey(0x007A71);
            public static FormLink<IPerkGetter> ASX_DraugrFactionProficiencyPerk          => ModKey.MakeFormKey(0x007A72);
            public static FormLink<IPerkGetter> ASX_DremoraFactionProficiencyPerk         => ModKey.MakeFormKey(0x007A73);

            /* If the user distributes racial perks, add the dummy perk to the Player ref. A quest/script runs once after character creation that
			  checks if the player has the dummy perk. If so it will add the approrpriate racial perk to them.
			*/
            public static FormLink<IPerkGetter> ASX_DummyPerk => ModKey.MakeFormKey(0x008A98);
           

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
      
        /*Vokrii
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
     */
     /*     Adamant
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
      */
        
    }
}