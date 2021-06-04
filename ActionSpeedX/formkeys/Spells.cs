using Mutagen.Bethesda;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Skyrim;
using System.Collections.Generic;
using Mutagen.Bethesda.FormKeys.SkyrimSE;

namespace ActionSpeedX
{
    public static partial class FormKeys
    {


        public static class ActionSpeedXSpells
        {
            private static readonly ModKey ModKey = ModKey.FromNameAndExtension("ActionSpeedX.esp");

            private static FormLink<ISpellGetter> ASX_LightArmorShieldAttackSpeedPenaltyAbility1         => ModKey.MakeFormKey(0xbb4e);
            private static FormLink<ISpellGetter> ASX_LightArmorShieldAttackSpeedPenaltyAbility2         => ModKey.MakeFormKey(0xbb50);
            private static FormLink<ISpellGetter> ASX_LightArmorShieldAttackSpeedPenaltyAbility3         => ModKey.MakeFormKey(0xbb52);
            private static FormLink<ISpellGetter> ASX_LightArmorShieldAttackSpeedPenaltyAbility4         => ModKey.MakeFormKey(0xbb54);
            
            private static FormLink<ISpellGetter> ASX_LightArmorShieldMagicaRateMultPenaltyAbility1      => ModKey.MakeFormKey(0xc75c);
            private static FormLink<ISpellGetter> ASX_LightArmorShieldMagicaRateMultPenaltyAbility2      => ModKey.MakeFormKey(0xc75e);
            private static FormLink<ISpellGetter> ASX_LightArmorShieldMagicaRateMultPenaltyAbility3      => ModKey.MakeFormKey(0xc760);
            private static FormLink<ISpellGetter> ASX_LightArmorShieldMagicaRateMultPenaltyAbility4      => ModKey.MakeFormKey(0xc762);
            
            private static FormLink<ISpellGetter> ASX_LightArmorShieldMovementSpeedPenaltyAbility1       => ModKey.MakeFormKey(0xc186);
            private static FormLink<ISpellGetter> ASX_LightArmorShieldMovementSpeedPenaltyAbility2       => ModKey.MakeFormKey(0xc188);
            private static FormLink<ISpellGetter> ASX_LightArmorShieldMovementSpeedPenaltyAbility3       => ModKey.MakeFormKey(0xc18a);
            private static FormLink<ISpellGetter> ASX_LightArmorShieldMovementSpeedPenaltyAbility4       => ModKey.MakeFormKey(0xc18c);
            
            private static FormLink<ISpellGetter> ASX_LightArmorShieldStaminaRateMultPenaltyAbility1     => ModKey.MakeFormKey(0xc7d6);
            private static FormLink<ISpellGetter> ASX_LightArmorShieldStaminaRateMultPenaltyAbility2     => ModKey.MakeFormKey(0xc7d8);
            private static FormLink<ISpellGetter> ASX_LightArmorShieldStaminaRateMultPenaltyAbility3     => ModKey.MakeFormKey(0xc7da);
            private static FormLink<ISpellGetter> ASX_LightArmorShieldStaminaRateMultPenaltyAbility4     => ModKey.MakeFormKey(0xc7dc);
            
            private static FormLink<ISpellGetter> ASX_LightArmorGauntletsAttackSpeedPenaltyAbility1      => ModKey.MakeFormKey(0xbb3e);
            private static FormLink<ISpellGetter> ASX_LightArmorGauntletsAttackSpeedPenaltyAbility2      => ModKey.MakeFormKey(0xbb40);
            private static FormLink<ISpellGetter> ASX_LightArmorGauntletsAttackSpeedPenaltyAbility3      => ModKey.MakeFormKey(0xbb42);
            private static FormLink<ISpellGetter> ASX_LightArmorGauntletsAttackSpeedPenaltyAbility4      => ModKey.MakeFormKey(0xbb44);
            
            private static FormLink<ISpellGetter> ASX_LightArmorGauntletsMagicaRateMultPenaltyAbility1   => ModKey.MakeFormKey(0xc74c);
            private static FormLink<ISpellGetter> ASX_LightArmorGauntletsMagicaRateMultPenaltyAbility2   => ModKey.MakeFormKey(0xc74e);
            private static FormLink<ISpellGetter> ASX_LightArmorGauntletsMagicaRateMultPenaltyAbility3   => ModKey.MakeFormKey(0xc750);
            private static FormLink<ISpellGetter> ASX_LightArmorGauntletsMagicaRateMultPenaltyAbility4   => ModKey.MakeFormKey(0xc752);
            
            private static FormLink<ISpellGetter> ASX_LightArmorGauntletsMovementSpeedPenaltyAbility1    => ModKey.MakeFormKey(0xc176);
            private static FormLink<ISpellGetter> ASX_LightArmorGauntletsMovementSpeedPenaltyAbility2    => ModKey.MakeFormKey(0xc178);
            private static FormLink<ISpellGetter> ASX_LightArmorGauntletsMovementSpeedPenaltyAbility3    => ModKey.MakeFormKey(0xc17a);
            private static FormLink<ISpellGetter> ASX_LightArmorGauntletsMovementSpeedPenaltyAbility4    => ModKey.MakeFormKey(0xc17c);
            
            private static FormLink<ISpellGetter> ASX_LightArmorGauntletsRangedSpeedPenaltyAbility1      => ModKey.MakeFormKey(0xc10e);
            private static FormLink<ISpellGetter> ASX_LightArmorGauntletsRangedSpeedPenaltyAbility2      => ModKey.MakeFormKey(0xc110);
            private static FormLink<ISpellGetter> ASX_LightArmorGauntletsRangedSpeedPenaltyAbility3      => ModKey.MakeFormKey(0xc112);
            private static FormLink<ISpellGetter> ASX_LightArmorGauntletsRangedSpeedPenaltyAbility4      => ModKey.MakeFormKey(0xc114);
            
            private static FormLink<ISpellGetter> ASX_LightArmorGauntletsStaminaRateMultPenaltyAbility1  => ModKey.MakeFormKey(0xc7c6);
            private static FormLink<ISpellGetter> ASX_LightArmorGauntletsStaminaRateMultPenaltyAbility2  => ModKey.MakeFormKey(0xc7c8);
            private static FormLink<ISpellGetter> ASX_LightArmorGauntletsStaminaRateMultPenaltyAbility3  => ModKey.MakeFormKey(0xc7ca);
            private static FormLink<ISpellGetter> ASX_LightArmorGauntletsStaminaRateMultPenaltyAbility4  => ModKey.MakeFormKey(0xc7cc);
            
            private static FormLink<ISpellGetter> ASX_LightArmorBootsAttackSpeedPenaltyAbility1          => ModKey.MakeFormKey(0xbb2e);
            private static FormLink<ISpellGetter> ASX_LightArmorBootsAttackSpeedPenaltyAbility2          => ModKey.MakeFormKey(0xbb30);
            private static FormLink<ISpellGetter> ASX_LightArmorBootsAttackSpeedPenaltyAbility3          => ModKey.MakeFormKey(0xbb32);
            private static FormLink<ISpellGetter> ASX_LightArmorBootsAttackSpeedPenaltyAbility4          => ModKey.MakeFormKey(0xbb34);
            
            private static FormLink<ISpellGetter> ASX_LightArmorBootsMagicaRateMultPenaltyAbility1       => ModKey.MakeFormKey(0xc73c);
            private static FormLink<ISpellGetter> ASX_LightArmorBootsMagicaRateMultPenaltyAbility2       => ModKey.MakeFormKey(0xc73e);
            private static FormLink<ISpellGetter> ASX_LightArmorBootsMagicaRateMultPenaltyAbility3       => ModKey.MakeFormKey(0xc740);
            private static FormLink<ISpellGetter> ASX_LightArmorBootsMagicaRateMultPenaltyAbility4       => ModKey.MakeFormKey(0xc742);
            
            private static FormLink<ISpellGetter> ASX_LightArmorBootsMovementSpeedPenaltyAbility1        => ModKey.MakeFormKey(0xc166);
            private static FormLink<ISpellGetter> ASX_LightArmorBootsMovementSpeedPenaltyAbility2        => ModKey.MakeFormKey(0xc168);
            private static FormLink<ISpellGetter> ASX_LightArmorBootsMovementSpeedPenaltyAbility3        => ModKey.MakeFormKey(0xc16a);
            private static FormLink<ISpellGetter> ASX_LightArmorBootsMovementSpeedPenaltyAbility4        => ModKey.MakeFormKey(0xc16c);
            
            private static FormLink<ISpellGetter> ASX_LightArmorBootsRangedSpeedPenaltyAbility1          => ModKey.MakeFormKey(0xc0fe);
            private static FormLink<ISpellGetter> ASX_LightArmorBootsRangedSpeedPenaltyAbility2          => ModKey.MakeFormKey(0xc100);
            private static FormLink<ISpellGetter> ASX_LightArmorBootsRangedSpeedPenaltyAbility3          => ModKey.MakeFormKey(0xc102);
            private static FormLink<ISpellGetter> ASX_LightArmorBootsRangedSpeedPenaltyAbility4          => ModKey.MakeFormKey(0xc104);
            
            private static FormLink<ISpellGetter> ASX_LightArmorBootsStaminaRateMultPenaltyAbility1      => ModKey.MakeFormKey(0xc7b6);
            private static FormLink<ISpellGetter> ASX_LightArmorBootsStaminaRateMultPenaltyAbility2      => ModKey.MakeFormKey(0xc7b8);
            private static FormLink<ISpellGetter> ASX_LightArmorBootsStaminaRateMultPenaltyAbility3      => ModKey.MakeFormKey(0xc7ba);
            private static FormLink<ISpellGetter> ASX_LightArmorBootsStaminaRateMultPenaltyAbility4      => ModKey.MakeFormKey(0xc7bc);
            
            private static FormLink<ISpellGetter> ASX_LightArmorCuirassAttackSpeedPenaltyAbility1        => ModKey.MakeFormKey(0xbb36);
            private static FormLink<ISpellGetter> ASX_LightArmorCuirassAttackSpeedPenaltyAbility2        => ModKey.MakeFormKey(0xbb38);
            private static FormLink<ISpellGetter> ASX_LightArmorCuirassAttackSpeedPenaltyAbility3        => ModKey.MakeFormKey(0xbb3a);
            private static FormLink<ISpellGetter> ASX_LightArmorCuirassAttackSpeedPenaltyAbility4        => ModKey.MakeFormKey(0xbb3c);
            
            private static FormLink<ISpellGetter> ASX_LightArmorCuirassMagicaRateMultPenaltyAbility1     => ModKey.MakeFormKey(0xc744);
            private static FormLink<ISpellGetter> ASX_LightArmorCuirassMagicaRateMultPenaltyAbility2     => ModKey.MakeFormKey(0xc746);
            private static FormLink<ISpellGetter> ASX_LightArmorCuirassMagicaRateMultPenaltyAbility3     => ModKey.MakeFormKey(0xc748);
            private static FormLink<ISpellGetter> ASX_LightArmorCuirassMagicaRateMultPenaltyAbility4     => ModKey.MakeFormKey(0xc74a);
            
            private static FormLink<ISpellGetter> ASX_LightArmorCuirassMovementSpeedPenaltyAbility1      => ModKey.MakeFormKey(0xc16e);
            private static FormLink<ISpellGetter> ASX_LightArmorCuirassMovementSpeedPenaltyAbility2      => ModKey.MakeFormKey(0xc170);
            private static FormLink<ISpellGetter> ASX_LightArmorCuirassMovementSpeedPenaltyAbility3      => ModKey.MakeFormKey(0xc172);
            private static FormLink<ISpellGetter> ASX_LightArmorCuirassMovementSpeedPenaltyAbility4      => ModKey.MakeFormKey(0xc174);
            
            private static FormLink<ISpellGetter> ASX_LightArmorCuirassRangedSpeedPenaltyAbility1        => ModKey.MakeFormKey(0xc106);
            private static FormLink<ISpellGetter> ASX_LightArmorCuirassRangedSpeedPenaltyAbility2        => ModKey.MakeFormKey(0xc108);
            private static FormLink<ISpellGetter> ASX_LightArmorCuirassRangedSpeedPenaltyAbility3        => ModKey.MakeFormKey(0xc10a);
            private static FormLink<ISpellGetter> ASX_LightArmorCuirassRangedSpeedPenaltyAbility4        => ModKey.MakeFormKey(0xc10c);
            
            private static FormLink<ISpellGetter> ASX_LightArmorCuirassStaminaRateMultPenaltyAbility1    => ModKey.MakeFormKey(0xc7be);
            private static FormLink<ISpellGetter> ASX_LightArmorCuirassStaminaRateMultPenaltyAbility2    => ModKey.MakeFormKey(0xc7c0);
            private static FormLink<ISpellGetter> ASX_LightArmorCuirassStaminaRateMultPenaltyAbility3    => ModKey.MakeFormKey(0xc7c2);
            private static FormLink<ISpellGetter> ASX_LightArmorCuirassStaminaRateMultPenaltyAbility4    => ModKey.MakeFormKey(0xc7c4);
            
            private static FormLink<ISpellGetter> ASX_LightArmorHelmetAttackSpeedPenaltyAbility1         => ModKey.MakeFormKey(0xbb46);
            private static FormLink<ISpellGetter> ASX_LightArmorHelmetAttackSpeedPenaltyAbility2         => ModKey.MakeFormKey(0xbb48);
            private static FormLink<ISpellGetter> ASX_LightArmorHelmetAttackSpeedPenaltyAbility3         => ModKey.MakeFormKey(0xbb4a);
            private static FormLink<ISpellGetter> ASX_LightArmorHelmetAttackSpeedPenaltyAbility4         => ModKey.MakeFormKey(0xbb4c);
            
            private static FormLink<ISpellGetter> ASX_LightArmorHelmetMagicaRateMultPenaltyAbility1      => ModKey.MakeFormKey(0xc754);
            private static FormLink<ISpellGetter> ASX_LightArmorHelmetMagicaRateMultPenaltyAbility2      => ModKey.MakeFormKey(0xc756);
            private static FormLink<ISpellGetter> ASX_LightArmorHelmetMagicaRateMultPenaltyAbility3      => ModKey.MakeFormKey(0xc758);
            private static FormLink<ISpellGetter> ASX_LightArmorHelmetMagicaRateMultPenaltyAbility4      => ModKey.MakeFormKey(0xc75a);
            
            private static FormLink<ISpellGetter> ASX_LightArmorHelmetMovementSpeedPenaltyAbility1       => ModKey.MakeFormKey(0xc17e);
            private static FormLink<ISpellGetter> ASX_LightArmorHelmetMovementSpeedPenaltyAbility2       => ModKey.MakeFormKey(0xc180);
            private static FormLink<ISpellGetter> ASX_LightArmorHelmetMovementSpeedPenaltyAbility3       => ModKey.MakeFormKey(0xc182);
            private static FormLink<ISpellGetter> ASX_LightArmorHelmetMovementSpeedPenaltyAbility4       => ModKey.MakeFormKey(0xc184);
            
            private static FormLink<ISpellGetter> ASX_LightArmorHelmetRangedSpeedPenaltyAbility1         => ModKey.MakeFormKey(0xc116);
            private static FormLink<ISpellGetter> ASX_LightArmorHelmetRangedSpeedPenaltyAbility2         => ModKey.MakeFormKey(0xc118);
            private static FormLink<ISpellGetter> ASX_LightArmorHelmetRangedSpeedPenaltyAbility3         => ModKey.MakeFormKey(0xc11a);
            private static FormLink<ISpellGetter> ASX_LightArmorHelmetRangedSpeedPenaltyAbility4         => ModKey.MakeFormKey(0xc11c);
            
            private static FormLink<ISpellGetter> ASX_LightArmorHelmetStaminaRateMultPenaltyAbility1     => ModKey.MakeFormKey(0xc7ce);
            private static FormLink<ISpellGetter> ASX_LightArmorHelmetStaminaRateMultPenaltyAbility2     => ModKey.MakeFormKey(0xc7d0);
            private static FormLink<ISpellGetter> ASX_LightArmorHelmetStaminaRateMultPenaltyAbility3     => ModKey.MakeFormKey(0xc7d2);
            private static FormLink<ISpellGetter> ASX_LightArmorHelmetStaminaRateMultPenaltyAbility4     => ModKey.MakeFormKey(0xc7d4);
            
            /***********************************************************Heavy********************************************************/

            private static FormLink<ISpellGetter> ASX_HeavyArmorBootsAttackSpeedPenaltyAbility1          => ModKey.MakeFormKey(0xb040);
            private static FormLink<ISpellGetter> ASX_HeavyArmorBootsAttackSpeedPenaltyAbility2          => ModKey.MakeFormKey(0xb049);
            private static FormLink<ISpellGetter> ASX_HeavyArmorBootsAttackSpeedPenaltyAbility3          => ModKey.MakeFormKey(0xb04a);
            private static FormLink<ISpellGetter> ASX_HeavyArmorBootsAttackSpeedPenaltyAbility4          => ModKey.MakeFormKey(0xb04c);
            
            private static FormLink<ISpellGetter> ASX_HeavyArmorBootsMagickaRateMultPenaltyAbility1      => ModKey.MakeFormKey(0xc717);
            private static FormLink<ISpellGetter> ASX_HeavyArmorBootsMagickaRateMultPenaltyAbility2      => ModKey.MakeFormKey(0xc718);
            private static FormLink<ISpellGetter> ASX_HeavyArmorBootsMagickaRateMultPenaltyAbility3      => ModKey.MakeFormKey(0xc71a);
            private static FormLink<ISpellGetter> ASX_HeavyArmorBootsMagickaRateMultPenaltyAbility4      => ModKey.MakeFormKey(0xc71c);
            
            private static FormLink<ISpellGetter> ASX_HeavyArmorBootsMovementSpeedPenaltyAbility1        => ModKey.MakeFormKey(0xc13e);
            private static FormLink<ISpellGetter> ASX_HeavyArmorBootsMovementSpeedPenaltyAbility2        => ModKey.MakeFormKey(0xc140);
            private static FormLink<ISpellGetter> ASX_HeavyArmorBootsMovementSpeedPenaltyAbility3        => ModKey.MakeFormKey(0xc142);
            private static FormLink<ISpellGetter> ASX_HeavyArmorBootsMovementSpeedPenaltyAbility4        => ModKey.MakeFormKey(0xc144);
            
            private static FormLink<ISpellGetter> ASX_HeavyArmorBootsRangedSpeedPenaltyAbility1          => ModKey.MakeFormKey(0xc0de);
            private static FormLink<ISpellGetter> ASX_HeavyArmorBootsRangedSpeedPenaltyAbility2          => ModKey.MakeFormKey(0xc0e0);
            private static FormLink<ISpellGetter> ASX_HeavyArmorBootsRangedSpeedPenaltyAbility3          => ModKey.MakeFormKey(0xc0e2);
            private static FormLink<ISpellGetter> ASX_HeavyArmorBootsRangedSpeedPenaltyAbility4          => ModKey.MakeFormKey(0xc0e4);
            
            private static FormLink<ISpellGetter> ASX_HeavyArmorBootsStaminaRateMultPenaltyAbility1      => ModKey.MakeFormKey(0xc78c);
            private static FormLink<ISpellGetter> ASX_HeavyArmorBootsStaminaRateMultPenaltyAbility2      => ModKey.MakeFormKey(0xc78e);
            private static FormLink<ISpellGetter> ASX_HeavyArmorBootsStaminaRateMultPenaltyAbility3      => ModKey.MakeFormKey(0xc790);
            private static FormLink<ISpellGetter> ASX_HeavyArmorBootsStaminaRateMultPenaltyAbility4      => ModKey.MakeFormKey(0xc792);
            
            private static FormLink<ISpellGetter> ASX_HeavyArmorCuirassAttackSpeedPenaltyAbility1        => ModKey.MakeFormKey(0xb5af);
            private static FormLink<ISpellGetter> ASX_HeavyArmorCuirassAttackSpeedPenaltyAbility2        => ModKey.MakeFormKey(0xbb11);
            private static FormLink<ISpellGetter> ASX_HeavyArmorCuirassAttackSpeedPenaltyAbility3        => ModKey.MakeFormKey(0xbb12);
            private static FormLink<ISpellGetter> ASX_HeavyArmorCuirassAttackSpeedPenaltyAbility4        => ModKey.MakeFormKey(0xbb14);
            
            private static FormLink<ISpellGetter> ASX_HeavyArmorCuirassMagickaRateMultPenaltyAbility1    => ModKey.MakeFormKey(0xc71e);
            private static FormLink<ISpellGetter> ASX_HeavyArmorCuirassMagickaRateMultPenaltyAbility2    => ModKey.MakeFormKey(0xc720);
            private static FormLink<ISpellGetter> ASX_HeavyArmorCuirassMagickaRateMultPenaltyAbility3    => ModKey.MakeFormKey(0xc722);
            private static FormLink<ISpellGetter> ASX_HeavyArmorCuirassMagickaRateMultPenaltyAbility4    => ModKey.MakeFormKey(0xc724);
            
            private static FormLink<ISpellGetter> ASX_HeavyArmorCuirassMovementSpeedPenaltyAbility1      => ModKey.MakeFormKey(0xc146);
            private static FormLink<ISpellGetter> ASX_HeavyArmorCuirassMovementSpeedPenaltyAbility2      => ModKey.MakeFormKey(0xc148);
            private static FormLink<ISpellGetter> ASX_HeavyArmorCuirassMovementSpeedPenaltyAbility3      => ModKey.MakeFormKey(0xc14a);
            private static FormLink<ISpellGetter> ASX_HeavyArmorCuirassMovementSpeedPenaltyAbility4      => ModKey.MakeFormKey(0xc14c);
            
            private static FormLink<ISpellGetter> ASX_HeavyArmorCuirassRangedSpeedPenaltyAbility1        => ModKey.MakeFormKey(0xc0e6);
            private static FormLink<ISpellGetter> ASX_HeavyArmorCuirassRangedSpeedPenaltyAbility2        => ModKey.MakeFormKey(0xc0e8);
            private static FormLink<ISpellGetter> ASX_HeavyArmorCuirassRangedSpeedPenaltyAbility3        => ModKey.MakeFormKey(0xc0ea);
            private static FormLink<ISpellGetter> ASX_HeavyArmorCuirassRangedSpeedPenaltyAbility4        => ModKey.MakeFormKey(0xc0ec);
            
            private static FormLink<ISpellGetter> ASX_HeavyArmorCuirassStaminaRateMultPenaltyAbility1    => ModKey.MakeFormKey(0xc794);
            private static FormLink<ISpellGetter> ASX_HeavyArmorCuirassStaminaRateMultPenaltyAbility2    => ModKey.MakeFormKey(0xc796);
            private static FormLink<ISpellGetter> ASX_HeavyArmorCuirassStaminaRateMultPenaltyAbility3    => ModKey.MakeFormKey(0xc798);
            private static FormLink<ISpellGetter> ASX_HeavyArmorCuirassStaminaRateMultPenaltyAbility4    => ModKey.MakeFormKey(0xc79a);
            
            private static FormLink<ISpellGetter> ASX_HeavyArmorGauntletsAttackSpeedPenaltyAbility1      => ModKey.MakeFormKey(0xbb16);
            private static FormLink<ISpellGetter> ASX_HeavyArmorGauntletsAttackSpeedPenaltyAbility2      => ModKey.MakeFormKey(0xbb18);
            private static FormLink<ISpellGetter> ASX_HeavyArmorGauntletsAttackSpeedPenaltyAbility3      => ModKey.MakeFormKey(0xbb1a);
            private static FormLink<ISpellGetter> ASX_HeavyArmorGauntletsAttackSpeedPenaltyAbility4      => ModKey.MakeFormKey(0xbb1c);
            
            private static FormLink<ISpellGetter> ASX_HeavyArmorGauntletsMovementSpeedPenaltyAbility1    => ModKey.MakeFormKey(0xc14e);
            private static FormLink<ISpellGetter> ASX_HeavyArmorGauntletsMovementSpeedPenaltyAbility2    => ModKey.MakeFormKey(0xc150);
            private static FormLink<ISpellGetter> ASX_HeavyArmorGauntletsMovementSpeedPenaltyAbility3    => ModKey.MakeFormKey(0xc152);
            private static FormLink<ISpellGetter> ASX_HeavyArmorGauntletsMovementSpeedPenaltyAbility4    => ModKey.MakeFormKey(0xc154);
            
            private static FormLink<ISpellGetter> ASX_HeavyArmorGauntletsRangedSpeedPenaltyAbility1      => ModKey.MakeFormKey(0xc0ee);
            private static FormLink<ISpellGetter> ASX_HeavyArmorGauntletsRangedSpeedPenaltyAbility2      => ModKey.MakeFormKey(0xc0f0);
            private static FormLink<ISpellGetter> ASX_HeavyArmorGauntletsRangedSpeedPenaltyAbility3      => ModKey.MakeFormKey(0xc0f2);
            private static FormLink<ISpellGetter> ASX_HeavyArmorGauntletsRangedSpeedPenaltyAbility4      => ModKey.MakeFormKey(0xc0f4);
            
            private static FormLink<ISpellGetter> ASX_HeavyArmorGlovesMagickaRateMultPenaltyAbility1     => ModKey.MakeFormKey(0xc726);
            private static FormLink<ISpellGetter> ASX_HeavyArmorGlovesMagickaRateMultPenaltyAbility2     => ModKey.MakeFormKey(0xc728);
            private static FormLink<ISpellGetter> ASX_HeavyArmorGlovesMagickaRateMultPenaltyAbility3     => ModKey.MakeFormKey(0xc72a);
            private static FormLink<ISpellGetter> ASX_HeavyArmorGlovesMagickaRateMultPenaltyAbility4     => ModKey.MakeFormKey(0xc79c);
            
            private static FormLink<ISpellGetter> ASX_HeavyArmorGlovesStaminaRateMultPenaltyAbility1     => ModKey.MakeFormKey(0xc79e);
            private static FormLink<ISpellGetter> ASX_HeavyArmorGlovesStaminaRateMultPenaltyAbility2     => ModKey.MakeFormKey(0xc7a0);
            private static FormLink<ISpellGetter> ASX_HeavyArmorGlovesStaminaRateMultPenaltyAbility3     => ModKey.MakeFormKey(0xc7a2);
            private static FormLink<ISpellGetter> ASX_HeavyArmorGlovesStaminaRateMultPenaltyAbility4     => ModKey.MakeFormKey(0xc7a4);
            
            private static FormLink<ISpellGetter> ASX_HeavyArmorHelmetAttackSpeedPenaltyAbility1         => ModKey.MakeFormKey(0xbb1e);
            private static FormLink<ISpellGetter> ASX_HeavyArmorHelmetAttackSpeedPenaltyAbility2         => ModKey.MakeFormKey(0xbb20);
            private static FormLink<ISpellGetter> ASX_HeavyArmorHelmetAttackSpeedPenaltyAbility3         => ModKey.MakeFormKey(0xbb22);
            private static FormLink<ISpellGetter> ASX_HeavyArmorHelmetAttackSpeedPenaltyAbility4         => ModKey.MakeFormKey(0xbb24);
            
            private static FormLink<ISpellGetter> ASX_HeavyArmorHelmetMagickaRateMultPenaltyAbility1     => ModKey.MakeFormKey(0xc72c);
            private static FormLink<ISpellGetter> ASX_HeavyArmorHelmetMagickaRateMultPenaltyAbility2     => ModKey.MakeFormKey(0xc72e);
            private static FormLink<ISpellGetter> ASX_HeavyArmorHelmetMagickaRateMultPenaltyAbility3     => ModKey.MakeFormKey(0xc730);
            private static FormLink<ISpellGetter> ASX_HeavyArmorHelmetMagickaRateMultPenaltyAbility4     => ModKey.MakeFormKey(0xc732);
            
            private static FormLink<ISpellGetter> ASX_HeavyArmorHelmetMovementSpeedPenaltyAbility1       => ModKey.MakeFormKey(0xc156);
            private static FormLink<ISpellGetter> ASX_HeavyArmorHelmetMovementSpeedPenaltyAbility2       => ModKey.MakeFormKey(0xc158);
            private static FormLink<ISpellGetter> ASX_HeavyArmorHelmetMovementSpeedPenaltyAbility3       => ModKey.MakeFormKey(0xc15a);
            private static FormLink<ISpellGetter> ASX_HeavyArmorHelmetMovementSpeedPenaltyAbility4       => ModKey.MakeFormKey(0xc15c);
            
            private static FormLink<ISpellGetter> ASX_HeavyArmorHelmetRangedSpeedPenaltyAbility1         => ModKey.MakeFormKey(0xc0f6);
            private static FormLink<ISpellGetter> ASX_HeavyArmorHelmetRangedSpeedPenaltyAbility2         => ModKey.MakeFormKey(0xc0f8);
            private static FormLink<ISpellGetter> ASX_HeavyArmorHelmetRangedSpeedPenaltyAbility3         => ModKey.MakeFormKey(0xc0fa);
            private static FormLink<ISpellGetter> ASX_HeavyArmorHelmetRangedSpeedPenaltyAbility4         => ModKey.MakeFormKey(0xc0fc);
            
            private static FormLink<ISpellGetter> ASX_HeavyArmorHelmetStaminaRateMultPenaltyAbility1     => ModKey.MakeFormKey(0xc7a6);
            private static FormLink<ISpellGetter> ASX_HeavyArmorHelmetStaminaRateMultPenaltyAbility2     => ModKey.MakeFormKey(0xc7a8);
            private static FormLink<ISpellGetter> ASX_HeavyArmorHelmetStaminaRateMultPenaltyAbility3     => ModKey.MakeFormKey(0xc7aa);
            private static FormLink<ISpellGetter> ASX_HeavyArmorHelmetStaminaRateMultPenaltyAbility4     => ModKey.MakeFormKey(0xc7ac);
            
            private static FormLink<ISpellGetter> ASX_HeavyArmorShieldAttackSpeedPenaltyAbility1         => ModKey.MakeFormKey(0xbb26);
            private static FormLink<ISpellGetter> ASX_HeavyArmorShieldAttackSpeedPenaltyAbility2         => ModKey.MakeFormKey(0xbb28);
            private static FormLink<ISpellGetter> ASX_HeavyArmorShieldAttackSpeedPenaltyAbility3         => ModKey.MakeFormKey(0xbb2a);
            private static FormLink<ISpellGetter> ASX_HeavyArmorShieldAttackSpeedPenaltyAbility4         => ModKey.MakeFormKey(0xbb2c);
            
            private static FormLink<ISpellGetter> ASX_HeavyArmorShieldMagickaRateMultPenaltyAbility1     => ModKey.MakeFormKey(0xc734);
            private static FormLink<ISpellGetter> ASX_HeavyArmorShieldMagickaRateMultPenaltyAbility2     => ModKey.MakeFormKey(0xc736);
            private static FormLink<ISpellGetter> ASX_HeavyArmorShieldMagickaRateMultPenaltyAbility3     => ModKey.MakeFormKey(0xc738);
            private static FormLink<ISpellGetter> ASX_HeavyArmorShieldMagickaRateMultPenaltyAbility4     => ModKey.MakeFormKey(0xc73a);
            
            private static FormLink<ISpellGetter> ASX_HeavyArmorShieldMovementSpeedPenaltyAbility1       => ModKey.MakeFormKey(0xc15e);
            private static FormLink<ISpellGetter> ASX_HeavyArmorShieldMovementSpeedPenaltyAbility2       => ModKey.MakeFormKey(0xc160);
            private static FormLink<ISpellGetter> ASX_HeavyArmorShieldMovementSpeedPenaltyAbility3       => ModKey.MakeFormKey(0xc162);
            private static FormLink<ISpellGetter> ASX_HeavyArmorShieldMovementSpeedPenaltyAbility4       => ModKey.MakeFormKey(0xc164);
            
            private static FormLink<ISpellGetter> ASX_HeavyArmorShieldStaminaRateMultPenaltyAbility1     => ModKey.MakeFormKey(0xc7ae);
            private static FormLink<ISpellGetter> ASX_HeavyArmorShieldStaminaRateMultPenaltyAbility2     => ModKey.MakeFormKey(0xc7b0);
            private static FormLink<ISpellGetter> ASX_HeavyArmorShieldStaminaRateMultPenaltyAbility3     => ModKey.MakeFormKey(0xc7b2);
            private static FormLink<ISpellGetter> ASX_HeavyArmorShieldStaminaRateMultPenaltyAbility4     => ModKey.MakeFormKey(0xc7b4);

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

            public static readonly Dictionary<string, List<ArmorActionSpells>> LightArmorActionSpellCollection = new()
            {
                { "Boots", LightBootSpells },
                { "Cuirass", LightCuirassSpells },
                { "Gauntlets", LightGauntletsSpells },
                { "Helmet", LightHelmetSpells },
                { "Shield", LightShieldSpells }
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

            public static readonly Dictionary<string, List<ArmorActionSpells>> HeavyArmorActionSpellCollection = new()
            {
                { "Boots", HeavyBootSpells },
                { "Cuirass", HeavyCuirassSpells },
                { "Gauntlets", HeavyGauntletsSpells },
                { "Helmet", HeavyHelmetSpells },
                { "Shield", HeavyShieldSpells }
            };

            /**************************************************************Medium****************************************************/
            /*
            public static FormLink<ISpellGetter> ASX_MediumArmorBootsAttackSpeedPenaltyAbility1         => ModKey.MakeFormKey(0xc0b7);
            public static FormLink<ISpellGetter> ASX_MediumArmorBootsAttackSpeedPenaltyAbility2         => ModKey.MakeFormKey(0xc0b8);
            public static FormLink<ISpellGetter> ASX_MediumArmorBootsAttackSpeedPenaltyAbility3         => ModKey.MakeFormKey(0xc0ba);
            public static FormLink<ISpellGetter> ASX_MediumArmorBootsAttackSpeedPenaltyAbility4         => ModKey.MakeFormKey(0xc0bc);
            
            public static FormLink<ISpellGetter> ASX_MediumArmorBootsMagicaRateMultPenaltyAbility1      => ModKey.MakeFormKey(0xc764);
            public static FormLink<ISpellGetter> ASX_MediumArmorBootsMagicaRateMultPenaltyAbility2      => ModKey.MakeFormKey(0xc766);
            public static FormLink<ISpellGetter> ASX_MediumArmorBootsMagicaRateMultPenaltyAbility3      => ModKey.MakeFormKey(0xc768);
            public static FormLink<ISpellGetter> ASX_MediumArmorBootsMagicaRateMultPenaltyAbility4      => ModKey.MakeFormKey(0xc76a);
            
            public static FormLink<ISpellGetter> ASX_MediumArmorBootsMovementSpeedPenaltyAbility1       => ModKey.MakeFormKey(0xc18e);
            public static FormLink<ISpellGetter> ASX_MediumArmorBootsMovementSpeedPenaltyAbility2       => ModKey.MakeFormKey(0xc190);
            public static FormLink<ISpellGetter> ASX_MediumArmorBootsMovementSpeedPenaltyAbility3       => ModKey.MakeFormKey(0xc192);
            public static FormLink<ISpellGetter> ASX_MediumArmorBootsMovementSpeedPenaltyAbility4       => ModKey.MakeFormKey(0xc194);
            
            public static FormLink<ISpellGetter> ASX_MediumArmorBootsRangedSpeedPenaltyAbility1         => ModKey.MakeFormKey(0xc11e);
            public static FormLink<ISpellGetter> ASX_MediumArmorBootsRangedSpeedPenaltyAbility2         => ModKey.MakeFormKey(0xc120);
            public static FormLink<ISpellGetter> ASX_MediumArmorBootsRangedSpeedPenaltyAbility3         => ModKey.MakeFormKey(0xc122);
            public static FormLink<ISpellGetter> ASX_MediumArmorBootsRangedSpeedPenaltyAbility4         => ModKey.MakeFormKey(0xc124);
            
            public static FormLink<ISpellGetter> ASX_MediumArmorBootsStaminaRateMultPenaltyAbility1     => ModKey.MakeFormKey(0xc7de);
            public static FormLink<ISpellGetter> ASX_MediumArmorBootsStaminaRateMultPenaltyAbility2     => ModKey.MakeFormKey(0xc7e0);
            public static FormLink<ISpellGetter> ASX_MediumArmorBootsStaminaRateMultPenaltyAbility3     => ModKey.MakeFormKey(0xc7e2);
            public static FormLink<ISpellGetter> ASX_MediumArmorBootsStaminaRateMultPenaltyAbility4     => ModKey.MakeFormKey(0xc7e4);
            
            public static FormLink<ISpellGetter> ASX_MediumArmorCuirassAttackSpeedPenaltyAbility1       => ModKey.MakeFormKey(0xc0be);
            public static FormLink<ISpellGetter> ASX_MediumArmorCuirassAttackSpeedPenaltyAbility2       => ModKey.MakeFormKey(0xc0c0);
            public static FormLink<ISpellGetter> ASX_MediumArmorCuirassAttackSpeedPenaltyAbility3       => ModKey.MakeFormKey(0xc0c2);
            public static FormLink<ISpellGetter> ASX_MediumArmorCuirassAttackSpeedPenaltyAbility4       => ModKey.MakeFormKey(0xc0c4);
            
            public static FormLink<ISpellGetter> ASX_MediumArmorCuirassMagicaRateMultPenaltyAbility1    => ModKey.MakeFormKey(0xc76c);
            public static FormLink<ISpellGetter> ASX_MediumArmorCuirassMagicaRateMultPenaltyAbility2    => ModKey.MakeFormKey(0xc76e);
            public static FormLink<ISpellGetter> ASX_MediumArmorCuirassMagicaRateMultPenaltyAbility3    => ModKey.MakeFormKey(0xc770);
            public static FormLink<ISpellGetter> ASX_MediumArmorCuirassMagicaRateMultPenaltyAbility4    => ModKey.MakeFormKey(0xc772);
            
            public static FormLink<ISpellGetter> ASX_MediumArmorCuirassMovementSpeedPenaltyAbility1     => ModKey.MakeFormKey(0xc196);
            public static FormLink<ISpellGetter> ASX_MediumArmorCuirassMovementSpeedPenaltyAbility2     => ModKey.MakeFormKey(0xc198);
            public static FormLink<ISpellGetter> ASX_MediumArmorCuirassMovementSpeedPenaltyAbility3     => ModKey.MakeFormKey(0xc19a);
            public static FormLink<ISpellGetter> ASX_MediumArmorCuirassMovementSpeedPenaltyAbility4     => ModKey.MakeFormKey(0xc19c);
            
            public static FormLink<ISpellGetter> ASX_MediumArmorCuirassRangedSpeedPenaltyAbility1       => ModKey.MakeFormKey(0xc126);
            public static FormLink<ISpellGetter> ASX_MediumArmorCuirassRangedSpeedPenaltyAbility2       => ModKey.MakeFormKey(0xc128);
            public static FormLink<ISpellGetter> ASX_MediumArmorCuirassRangedSpeedPenaltyAbility3       => ModKey.MakeFormKey(0xc12a);
            public static FormLink<ISpellGetter> ASX_MediumArmorCuirassRangedSpeedPenaltyAbility4       => ModKey.MakeFormKey(0xc12c);
            
            public static FormLink<ISpellGetter> ASX_MediumArmorCuirassStaminaRateMultPenaltyAbility1   => ModKey.MakeFormKey(0xc7e6);
            public static FormLink<ISpellGetter> ASX_MediumArmorCuirassStaminaRateMultPenaltyAbility2   => ModKey.MakeFormKey(0xc7e8);
            public static FormLink<ISpellGetter> ASX_MediumArmorCuirassStaminaRateMultPenaltyAbility3   => ModKey.MakeFormKey(0xc7ea);
            public static FormLink<ISpellGetter> ASX_MediumArmorCuirassStaminaRateMultPenaltyAbility4   => ModKey.MakeFormKey(0xc7ec);
            
            public static FormLink<ISpellGetter> ASX_MediumArmorGauntletsAttackSpeedPenaltyAbility1     => ModKey.MakeFormKey(0xc0ce);
            public static FormLink<ISpellGetter> ASX_MediumArmorGauntletsAttackSpeedPenaltyAbility2     => ModKey.MakeFormKey(0xc0d0);
            public static FormLink<ISpellGetter> ASX_MediumArmorGauntletsAttackSpeedPenaltyAbility3     => ModKey.MakeFormKey(0xc0d2);
            public static FormLink<ISpellGetter> ASX_MediumArmorGauntletsAttackSpeedPenaltyAbility4     => ModKey.MakeFormKey(0xc0d4);
            
            public static FormLink<ISpellGetter> ASX_MediumArmorGauntletsMagicaRateMultPenaltyAbility1  => ModKey.MakeFormKey(0xc774);
            public static FormLink<ISpellGetter> ASX_MediumArmorGauntletsMagicaRateMultPenaltyAbility2  => ModKey.MakeFormKey(0xc776);
            public static FormLink<ISpellGetter> ASX_MediumArmorGauntletsMagicaRateMultPenaltyAbility3  => ModKey.MakeFormKey(0xc778);
            public static FormLink<ISpellGetter> ASX_MediumArmorGauntletsMagicaRateMultPenaltyAbility4  => ModKey.MakeFormKey(0xc77a);
            
            public static FormLink<ISpellGetter> ASX_MediumArmorGauntletsMovementSpeedPenaltyAbility1   => ModKey.MakeFormKey(0xc19e);
            public static FormLink<ISpellGetter> ASX_MediumArmorGauntletsMovementSpeedPenaltyAbility2   => ModKey.MakeFormKey(0xc1a0);
            public static FormLink<ISpellGetter> ASX_MediumArmorGauntletsMovementSpeedPenaltyAbility3   => ModKey.MakeFormKey(0xc1a2);
            public static FormLink<ISpellGetter> ASX_MediumArmorGauntletsMovementSpeedPenaltyAbility4   => ModKey.MakeFormKey(0xc1a4);
            
            public static FormLink<ISpellGetter> ASX_MediumArmorGauntletsRangedSpeedPenaltyAbility1     => ModKey.MakeFormKey(0xc12e);
            public static FormLink<ISpellGetter> ASX_MediumArmorGauntletsRangedSpeedPenaltyAbility2     => ModKey.MakeFormKey(0xc130);
            public static FormLink<ISpellGetter> ASX_MediumArmorGauntletsRangedSpeedPenaltyAbility3     => ModKey.MakeFormKey(0xc132);
            public static FormLink<ISpellGetter> ASX_MediumArmorGauntletsRangedSpeedPenaltyAbility4     => ModKey.MakeFormKey(0xc134);
            
            public static FormLink<ISpellGetter> ASX_MediumArmorGauntletsStaminaRateMultPenaltyAbility1 => ModKey.MakeFormKey(0xc7ee);
            public static FormLink<ISpellGetter> ASX_MediumArmorGauntletsStaminaRateMultPenaltyAbility2 => ModKey.MakeFormKey(0xc7f0);
            public static FormLink<ISpellGetter> ASX_MediumArmorGauntletsStaminaRateMultPenaltyAbility3 => ModKey.MakeFormKey(0xc7f2);
            public static FormLink<ISpellGetter> ASX_MediumArmorGauntletsStaminaRateMultPenaltyAbility4 => ModKey.MakeFormKey(0xc7f4);
            
            public static FormLink<ISpellGetter> ASX_MediumArmorHelmetAttackSpeedPenaltyAbility1        => ModKey.MakeFormKey(0xc0c6);
            public static FormLink<ISpellGetter> ASX_MediumArmorHelmetAttackSpeedPenaltyAbility2        => ModKey.MakeFormKey(0xc0c8);
            public static FormLink<ISpellGetter> ASX_MediumArmorHelmetAttackSpeedPenaltyAbility3        => ModKey.MakeFormKey(0xc0ca);
            public static FormLink<ISpellGetter> ASX_MediumArmorHelmetAttackSpeedPenaltyAbility4        => ModKey.MakeFormKey(0xc0cc);
            
            public static FormLink<ISpellGetter> ASX_MediumArmorHelmetMagicaRateMultPenaltyAbility1     => ModKey.MakeFormKey(0xc77c);
            public static FormLink<ISpellGetter> ASX_MediumArmorHelmetMagicaRateMultPenaltyAbility2     => ModKey.MakeFormKey(0xc77e);
            public static FormLink<ISpellGetter> ASX_MediumArmorHelmetMagicaRateMultPenaltyAbility3     => ModKey.MakeFormKey(0xc780);
            public static FormLink<ISpellGetter> ASX_MediumArmorHelmetMagicaRateMultPenaltyAbility4     => ModKey.MakeFormKey(0xc782);
            
            public static FormLink<ISpellGetter> ASX_MediumArmorHelmetMovementSpeedPenaltyAbility1      => ModKey.MakeFormKey(0xc1a6);
            public static FormLink<ISpellGetter> ASX_MediumArmorHelmetMovementSpeedPenaltyAbility2      => ModKey.MakeFormKey(0xc1a8);
            public static FormLink<ISpellGetter> ASX_MediumArmorHelmetMovementSpeedPenaltyAbility3      => ModKey.MakeFormKey(0xc1aa);
            public static FormLink<ISpellGetter> ASX_MediumArmorHelmetMovementSpeedPenaltyAbility4      => ModKey.MakeFormKey(0xc1ac);
            
            public static FormLink<ISpellGetter> ASX_MediumArmorHelmetRangedSpeedPenaltyAbility1        => ModKey.MakeFormKey(0xc136);
            public static FormLink<ISpellGetter> ASX_MediumArmorHelmetRangedSpeedPenaltyAbility2        => ModKey.MakeFormKey(0xc138);
            public static FormLink<ISpellGetter> ASX_MediumArmorHelmetRangedSpeedPenaltyAbility3        => ModKey.MakeFormKey(0xc13a);
            public static FormLink<ISpellGetter> ASX_MediumArmorHelmetRangedSpeedPenaltyAbility4        => ModKey.MakeFormKey(0xc13c);
            
            public static FormLink<ISpellGetter> ASX_MediumArmorHelmetStaminaRateMultPenaltyAbility1    => ModKey.MakeFormKey(0xc7f6);
            public static FormLink<ISpellGetter> ASX_MediumArmorHelmetStaminaRateMultPenaltyAbility2    => ModKey.MakeFormKey(0xc7f8);
            public static FormLink<ISpellGetter> ASX_MediumArmorHelmetStaminaRateMultPenaltyAbility3    => ModKey.MakeFormKey(0xc7fa);
            public static FormLink<ISpellGetter> ASX_MediumArmorHelmetStaminaRateMultPenaltyAbility4    => ModKey.MakeFormKey(0xc7fc);
            
            public static FormLink<ISpellGetter> ASX_MediumArmorShieldAttackSpeedPenaltyAbility1        => ModKey.MakeFormKey(0xc0d6);
            public static FormLink<ISpellGetter> ASX_MediumArmorShieldAttackSpeedPenaltyAbility2        => ModKey.MakeFormKey(0xc0d8);
            public static FormLink<ISpellGetter> ASX_MediumArmorShieldAttackSpeedPenaltyAbility3        => ModKey.MakeFormKey(0xc0da);
            public static FormLink<ISpellGetter> ASX_MediumArmorShieldAttackSpeedPenaltyAbility4        => ModKey.MakeFormKey(0xc0dc);
            
            public static FormLink<ISpellGetter> ASX_MediumArmorShieldMagicaRateMultPenaltyAbility1     => ModKey.MakeFormKey(0xc784);
            public static FormLink<ISpellGetter> ASX_MediumArmorShieldMagicaRateMultPenaltyAbility2     => ModKey.MakeFormKey(0xc786);
            public static FormLink<ISpellGetter> ASX_MediumArmorShieldMagicaRateMultPenaltyAbility3     => ModKey.MakeFormKey(0xc788);
            public static FormLink<ISpellGetter> ASX_MediumArmorShieldMagicaRateMultPenaltyAbility4     => ModKey.MakeFormKey(0xc78a);
            
            public static FormLink<ISpellGetter> ASX_MediumArmorShieldMovementSpeedPenaltyAbility1      => ModKey.MakeFormKey(0xc1ae);
            public static FormLink<ISpellGetter> ASX_MediumArmorShieldMovementSpeedPenaltyAbility2      => ModKey.MakeFormKey(0xc1b0);
            public static FormLink<ISpellGetter> ASX_MediumArmorShieldMovementSpeedPenaltyAbility3      => ModKey.MakeFormKey(0xc1b2);
            public static FormLink<ISpellGetter> ASX_MediumArmorShieldMovementSpeedPenaltyAbility4      => ModKey.MakeFormKey(0xc1b4);
            
            public static FormLink<ISpellGetter> ASX_MediumArmorShieldStaminaRateMultPenaltyAbility1    => ModKey.MakeFormKey(0xc7fe);
            public static FormLink<ISpellGetter> ASX_MediumArmorShieldStaminaRateMultPenaltyAbility2    => ModKey.MakeFormKey(0xc800);
            public static FormLink<ISpellGetter> ASX_MediumArmorShieldStaminaRateMultPenaltyAbility3    => ModKey.MakeFormKey(0xc802);
            public static FormLink<ISpellGetter> ASX_MediumArmorShieldStaminaRateMultPenaltyAbility4    => ModKey.MakeFormKey(0xc804);

            static readonly List<ArmorActionSpells> MediumBootSpells = new()
            {
                new ArmorActionSpells(ASX_MediumArmorBootsAttackSpeedPenaltyAbility1, ASX_MediumArmorBootsRangedSpeedPenaltyAbility1, ASX_MediumArmorBootsMovementSpeedPenaltyAbility1, ASX_MediumArmorBootsMagicaRateMultPenaltyAbility1, ASX_MediumArmorBootsStaminaRateMultPenaltyAbility1),
                new ArmorActionSpells(ASX_MediumArmorBootsAttackSpeedPenaltyAbility2, ASX_MediumArmorBootsRangedSpeedPenaltyAbility2, ASX_MediumArmorBootsMovementSpeedPenaltyAbility2, ASX_MediumArmorBootsMagicaRateMultPenaltyAbility2, ASX_MediumArmorBootsStaminaRateMultPenaltyAbility2),
                new ArmorActionSpells(ASX_MediumArmorBootsAttackSpeedPenaltyAbility3, ASX_MediumArmorBootsRangedSpeedPenaltyAbility3, ASX_MediumArmorBootsMovementSpeedPenaltyAbility3, ASX_MediumArmorBootsMagicaRateMultPenaltyAbility3, ASX_MediumArmorBootsStaminaRateMultPenaltyAbility3),
                new ArmorActionSpells(ASX_MediumArmorBootsAttackSpeedPenaltyAbility4, ASX_MediumArmorBootsRangedSpeedPenaltyAbility4, ASX_MediumArmorBootsMovementSpeedPenaltyAbility4, ASX_MediumArmorBootsMagicaRateMultPenaltyAbility4, ASX_MediumArmorBootsStaminaRateMultPenaltyAbility4)

            };

            static readonly List<ArmorActionSpells> MediumCuirassSpells = new()
            {
                new ArmorActionSpells(ASX_MediumArmorCuirassAttackSpeedPenaltyAbility1, ASX_MediumArmorCuirassRangedSpeedPenaltyAbility1, ASX_MediumArmorCuirassMovementSpeedPenaltyAbility1, ASX_MediumArmorCuirassMagicaRateMultPenaltyAbility1, ASX_MediumArmorCuirassStaminaRateMultPenaltyAbility1),
                new ArmorActionSpells(ASX_MediumArmorCuirassAttackSpeedPenaltyAbility2, ASX_MediumArmorCuirassRangedSpeedPenaltyAbility2, ASX_MediumArmorCuirassMovementSpeedPenaltyAbility2, ASX_MediumArmorCuirassMagicaRateMultPenaltyAbility2, ASX_MediumArmorCuirassStaminaRateMultPenaltyAbility2),
                new ArmorActionSpells(ASX_MediumArmorCuirassAttackSpeedPenaltyAbility3, ASX_MediumArmorCuirassRangedSpeedPenaltyAbility3, ASX_MediumArmorCuirassMovementSpeedPenaltyAbility3, ASX_MediumArmorCuirassMagicaRateMultPenaltyAbility3, ASX_MediumArmorCuirassStaminaRateMultPenaltyAbility3),
                new ArmorActionSpells(ASX_MediumArmorCuirassAttackSpeedPenaltyAbility4, ASX_MediumArmorCuirassRangedSpeedPenaltyAbility4, ASX_MediumArmorCuirassMovementSpeedPenaltyAbility4, ASX_MediumArmorCuirassMagicaRateMultPenaltyAbility4, ASX_MediumArmorCuirassStaminaRateMultPenaltyAbility4)

            };

            static readonly List<ArmorActionSpells> MediumGauntletsSpells = new()
            {
                new ArmorActionSpells(ASX_MediumArmorGauntletsAttackSpeedPenaltyAbility1, ASX_MediumArmorGauntletsRangedSpeedPenaltyAbility1, ASX_MediumArmorGauntletsMovementSpeedPenaltyAbility1, ASX_MediumArmorGauntletsMagicaRateMultPenaltyAbility1, ASX_MediumArmorGauntletsStaminaRateMultPenaltyAbility1),
                new ArmorActionSpells(ASX_MediumArmorGauntletsAttackSpeedPenaltyAbility2, ASX_MediumArmorGauntletsRangedSpeedPenaltyAbility2, ASX_MediumArmorGauntletsMovementSpeedPenaltyAbility2, ASX_MediumArmorGauntletsMagicaRateMultPenaltyAbility2, ASX_MediumArmorGauntletsStaminaRateMultPenaltyAbility2),
                new ArmorActionSpells(ASX_MediumArmorGauntletsAttackSpeedPenaltyAbility3, ASX_MediumArmorGauntletsRangedSpeedPenaltyAbility3, ASX_MediumArmorGauntletsMovementSpeedPenaltyAbility3, ASX_MediumArmorGauntletsMagicaRateMultPenaltyAbility3, ASX_MediumArmorGauntletsStaminaRateMultPenaltyAbility3),
                new ArmorActionSpells(ASX_MediumArmorGauntletsAttackSpeedPenaltyAbility4, ASX_MediumArmorGauntletsRangedSpeedPenaltyAbility4, ASX_MediumArmorGauntletsMovementSpeedPenaltyAbility4, ASX_MediumArmorGauntletsMagicaRateMultPenaltyAbility4, ASX_MediumArmorGauntletsStaminaRateMultPenaltyAbility4)

            };

            static readonly List<ArmorActionSpells> MediumHelmetSpells = new()
            {
                new ArmorActionSpells(ASX_MediumArmorHelmetAttackSpeedPenaltyAbility1, ASX_MediumArmorHelmetRangedSpeedPenaltyAbility1, ASX_MediumArmorHelmetMovementSpeedPenaltyAbility1, ASX_MediumArmorHelmetMagicaRateMultPenaltyAbility1, ASX_MediumArmorHelmetStaminaRateMultPenaltyAbility1),
                new ArmorActionSpells(ASX_MediumArmorHelmetAttackSpeedPenaltyAbility2, ASX_MediumArmorHelmetRangedSpeedPenaltyAbility2, ASX_MediumArmorHelmetMovementSpeedPenaltyAbility2, ASX_MediumArmorHelmetMagicaRateMultPenaltyAbility2, ASX_MediumArmorHelmetStaminaRateMultPenaltyAbility2),
                new ArmorActionSpells(ASX_MediumArmorHelmetAttackSpeedPenaltyAbility3, ASX_MediumArmorHelmetRangedSpeedPenaltyAbility3, ASX_MediumArmorHelmetMovementSpeedPenaltyAbility3, ASX_MediumArmorHelmetMagicaRateMultPenaltyAbility3, ASX_MediumArmorHelmetStaminaRateMultPenaltyAbility3),
                new ArmorActionSpells(ASX_MediumArmorHelmetAttackSpeedPenaltyAbility4, ASX_MediumArmorHelmetRangedSpeedPenaltyAbility4, ASX_MediumArmorHelmetMovementSpeedPenaltyAbility4, ASX_MediumArmorHelmetMagicaRateMultPenaltyAbility4, ASX_MediumArmorHelmetStaminaRateMultPenaltyAbility4)

            };

            static readonly List<ArmorActionSpells> MediumShieldSpells = new()
            {
                new ArmorActionSpells(ASX_MediumArmorShieldAttackSpeedPenaltyAbility1, ASX_MediumArmorShieldRangedSpeedPenaltyAbility1, ASX_MediumArmorShieldMovementSpeedPenaltyAbility1, ASX_MediumArmorShieldMagicaRateMultPenaltyAbility1, ASX_MediumArmorShieldStaminaRateMultPenaltyAbility1),
                new ArmorActionSpells(ASX_MediumArmorShieldAttackSpeedPenaltyAbility2, ASX_MediumArmorShieldRangedSpeedPenaltyAbility2, ASX_MediumArmorShieldMovementSpeedPenaltyAbility2, ASX_MediumArmorShieldMagicaRateMultPenaltyAbility2, ASX_MediumArmorShieldStaminaRateMultPenaltyAbility2),
                new ArmorActionSpells(ASX_MediumArmorShieldAttackSpeedPenaltyAbility3, ASX_MediumArmorShieldRangedSpeedPenaltyAbility3, ASX_MediumArmorShieldMovementSpeedPenaltyAbility3, ASX_MediumArmorShieldMagicaRateMultPenaltyAbility3, ASX_MediumArmorShieldStaminaRateMultPenaltyAbility3),
                new ArmorActionSpells(ASX_MediumArmorShieldAttackSpeedPenaltyAbility4, ASX_MediumArmorShieldRangedSpeedPenaltyAbility4, ASX_MediumArmorShieldMovementSpeedPenaltyAbility4, ASX_MediumArmorShieldMagicaRateMultPenaltyAbility4, ASX_MediumArmorShieldStaminaRateMultPenaltyAbility4)

            };
            public static readonly Dictionary<string, List<ArmorActionSpells>> MediumArmorActionSpellCollection = new()
            {
                { "Boots", MediumBootSpells },
                { "Cuirass", MediumCuirassSpells },
                { "Gauntlets", MediumGauntletsSpells },
                { "Helmet", MediumHelmetSpells },
                { "Shield", MediumShieldSpells }
            };
          */

        }

        /// <summary>
        /// This class contains abilities from adamant that touch staminaratemult, and movementspeed. It contains instructions on how to rebalance those abilities.
        /// It covers the following perks: Agility, Athletics, and also handles the Pilgrim of Akatash buff
        /// </summary>
        public static class AdamantSpells
        {
            /**
            Agility: Agility gives 50/100% stamina renegeration at level 40/60 with light armor. ASX nerfs stamina regen by 15/20% assuming your skill matches the armor tier. We nerf to 5%
            Athletics: Athletics Give 10/20% speed boost. The max light armor speed reduction from ASX is 10% when on level. We nerf it to give 1/2% total(3) speed which is ~equal to offsetting gauntlets
            */

            private static ModKey ModKey                               = ModKey.FromNameAndExtension("Adamant.esp");         
            private static FormLink<ISpellGetter> MAG_PerkAgility30    => Skyrim.Spell.PerkWindWalkerStamina.FormKey; // This will be reduced from 50% -> 5%. Affects stamina regeneration. 
            private static FormLink<ISpellGetter> MAG_PerkAgility60    => ModKey.MakeFormKey(0x0F38DA); // This will be reduced from 100% -> 5%. Affects stamina regeneration
            private static FormLink<ISpellGetter> MAG_abAthletics40    => ModKey.MakeFormKey(0x0F38D7); // This will be reduced from 10 -> 1%. Affects movement speed
            private static FormLink<ISpellGetter> MAG_abAthletics60    => ModKey.MakeFormKey(0x153BF7); // This will be reduced from 10-> 2%. Affects movement speed.


            public static readonly List<SpellEffectModifier> StaminaSpells = new List<SpellEffectModifier> { 
                new SpellEffectModifier(MAG_PerkAgility30, 0, 5.0f, "MAG_PerkAgility30"),
                new SpellEffectModifier(MAG_PerkAgility60, 0, 5.0f, "MAG_PerkAgility60")
            };
            public static readonly List<SpellEffectModifier> MoveSpells = new List<SpellEffectModifier> { 
                new SpellEffectModifier(MAG_abAthletics40, 0, 1.0f, "MAG_abAthletics40"),
                new SpellEffectModifier(MAG_abAthletics60, 0, 2.0f, "MAG_abAthletics60"),
            };
        }

        /// <summary>
        /// This class contains abilities from ordinator that touch staminaratemult, and movementspeed. It contains instructions on how to rebalance those abilities.
        /// It covers the following perks: Windborne, Windrunner, Fight or Flight
        /// </summary>
        public static class OrdinatorSpells
        {
            private static ModKey ModKey = ModKey.FromNameAndExtension("Ordinator - Perks Of Skyrim.esp");
            private static FormLink<ISpellGetter> ORD_Lia_Windrunner_Spell_Ab      => ModKey.MakeFormKey(0x009B8D); // -> 1% movespeed for light armor skill 40
            private static FormLink<ISpellGetter> ORD_Lia_FightOrFlight_Spell_Ab   => ModKey.MakeFormKey(0x17C1DC); // Stamina regen. 10% -> 3% ??

            public static readonly List<SpellEffectModifier> StaminaSpells = new List<SpellEffectModifier> {
                new SpellEffectModifier(ORD_Lia_FightOrFlight_Spell_Ab, 1, 3.0f, "ORD_Lia_FightOrFlight_Spell_Ab"),

            };

            public static readonly List<SpellEffectModifier> MoveSpells = new List<SpellEffectModifier> {
                new SpellEffectModifier(ORD_Lia_Windrunner_Spell_Ab, 0, 1.0f, "ORD_Lia_Windrunner_Spell_Ab"),
            };
        }

        /// <summary>
        /// This class contains abilities from vokrii that touch staminaratemult, and movementspeed. It contains instructions on how to rebalance those abilities.
        /// It covers the following perks: Adrenaline, WardDancer, and WindRunner
        /// </summary>
        public static class VokriiSpells
        {
            /*
             * Adrenaline: Adrenaline gives a + 10% speed buff when consuming potions. We reduce this to 4% which enough to offset the penalty of low level cuirass
             * Warddancer: Wardancer gives a 10% speed buff fo blocking. We reduce this to 1% as we already give a passive speed bonus based on LA skill.
             * WindRunner: Windrunner gives a 10% speed buff in combat that lasts as long as you aren't hit. We already passively give speed bonus based on LA skill so this is nerfed.
             */

            private static ModKey ModKey = ModKey.FromNameAndExtension("Vokrii - Minimalistic Perks of Skyrim.esp");

            private static FormLink<ISpellGetter> VKR_Lia_Windrunner_Spell_Ab => ModKey.MakeFormKey(0x009B89); // Reduce move speed buff from 10% -> 1%

            public static readonly List<SpellEffectModifier> StaminaSpells = new List<SpellEffectModifier> {};
            public static readonly List<SpellEffectModifier> MoveSpells    = new List<SpellEffectModifier> {
                new SpellEffectModifier(VKR_Lia_Windrunner_Spell_Ab, 0, 1.0f, "VKR_Lia_Winrunner_Spell_Ab")

            };
        }

        /// <summary>
        /// This contains a spell records form id, editorid, effect index, and magnitude.
        ///
        /// </summary>
        public class SpellEffectModifier
        {
            public FormLink<ISpellGetter> SpellForm; // id
            public int EffectSlot; // index to modify in effects array
            public float Magnitude; // value to set
            public string EditorId; // Editor ID in case record throws an error.
            public SpellEffectModifier(FormLink<ISpellGetter> formLink, int effectSlot, float magnitude, string id)
            {
                this.SpellForm  = formLink;
                this.EffectSlot = effectSlot;
                this.Magnitude  = magnitude;
                this.EditorId   = id;
            }
        }

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
                this.AttackSpell       = attack;
                this.RangedAttackSpell = rangedAttack;
                this.SpeedSpell        = speed;
                this.MagickaSpell      = magicka;
                this.StaminaSpell      = stamina;
            }


        }
    }
}