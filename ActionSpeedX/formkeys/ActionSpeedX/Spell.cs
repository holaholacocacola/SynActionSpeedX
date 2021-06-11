using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Skyrim;
using System.Collections.Generic;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class ActionSpeedX_
    {
        public static class Spell
        {
            private static readonly ModKey ModKey = ModKey.FromNameAndExtension("ActionSpeedX.esp");

            public static FormLink<ISpellGetter> ASX_LightArmorShieldAttackSpeedPenaltyAbility1         => ModKey.MakeFormKey(0xbb4e);
            public static FormLink<ISpellGetter> ASX_LightArmorShieldAttackSpeedPenaltyAbility2         => ModKey.MakeFormKey(0xbb50);
            public static FormLink<ISpellGetter> ASX_LightArmorShieldAttackSpeedPenaltyAbility3         => ModKey.MakeFormKey(0xbb52);
            public static FormLink<ISpellGetter> ASX_LightArmorShieldAttackSpeedPenaltyAbility4         => ModKey.MakeFormKey(0xbb54);
            
            public static FormLink<ISpellGetter> ASX_LightArmorShieldMagicaRateMultPenaltyAbility1      => ModKey.MakeFormKey(0xc75c);
            public static FormLink<ISpellGetter> ASX_LightArmorShieldMagicaRateMultPenaltyAbility2      => ModKey.MakeFormKey(0xc75e);
            public static FormLink<ISpellGetter> ASX_LightArmorShieldMagicaRateMultPenaltyAbility3      => ModKey.MakeFormKey(0xc760);
            public static FormLink<ISpellGetter> ASX_LightArmorShieldMagicaRateMultPenaltyAbility4      => ModKey.MakeFormKey(0xc762);
            
            public static FormLink<ISpellGetter> ASX_LightArmorShieldMovementSpeedPenaltyAbility1       => ModKey.MakeFormKey(0xc186);
            public static FormLink<ISpellGetter> ASX_LightArmorShieldMovementSpeedPenaltyAbility2       => ModKey.MakeFormKey(0xc188);
            public static FormLink<ISpellGetter> ASX_LightArmorShieldMovementSpeedPenaltyAbility3       => ModKey.MakeFormKey(0xc18a);
            public static FormLink<ISpellGetter> ASX_LightArmorShieldMovementSpeedPenaltyAbility4       => ModKey.MakeFormKey(0xc18c);
            
            public static FormLink<ISpellGetter> ASX_LightArmorShieldStaminaRateMultPenaltyAbility1     => ModKey.MakeFormKey(0xc7d6);
            public static FormLink<ISpellGetter> ASX_LightArmorShieldStaminaRateMultPenaltyAbility2     => ModKey.MakeFormKey(0xc7d8);
            public static FormLink<ISpellGetter> ASX_LightArmorShieldStaminaRateMultPenaltyAbility3     => ModKey.MakeFormKey(0xc7da);
            public static FormLink<ISpellGetter> ASX_LightArmorShieldStaminaRateMultPenaltyAbility4     => ModKey.MakeFormKey(0xc7dc);
            
            public static FormLink<ISpellGetter> ASX_LightArmorGauntletsAttackSpeedPenaltyAbility1      => ModKey.MakeFormKey(0xbb3e);
            public static FormLink<ISpellGetter> ASX_LightArmorGauntletsAttackSpeedPenaltyAbility2      => ModKey.MakeFormKey(0xbb40);
            public static FormLink<ISpellGetter> ASX_LightArmorGauntletsAttackSpeedPenaltyAbility3      => ModKey.MakeFormKey(0xbb42);
            public static FormLink<ISpellGetter> ASX_LightArmorGauntletsAttackSpeedPenaltyAbility4      => ModKey.MakeFormKey(0xbb44);
            
            public static FormLink<ISpellGetter> ASX_LightArmorGauntletsMagicaRateMultPenaltyAbility1   => ModKey.MakeFormKey(0xc74c);
            public static FormLink<ISpellGetter> ASX_LightArmorGauntletsMagicaRateMultPenaltyAbility2   => ModKey.MakeFormKey(0xc74e);
            public static FormLink<ISpellGetter> ASX_LightArmorGauntletsMagicaRateMultPenaltyAbility3   => ModKey.MakeFormKey(0xc750);
            public static FormLink<ISpellGetter> ASX_LightArmorGauntletsMagicaRateMultPenaltyAbility4   => ModKey.MakeFormKey(0xc752);
            
            public static FormLink<ISpellGetter> ASX_LightArmorGauntletsMovementSpeedPenaltyAbility1    => ModKey.MakeFormKey(0xc176);
            public static FormLink<ISpellGetter> ASX_LightArmorGauntletsMovementSpeedPenaltyAbility2    => ModKey.MakeFormKey(0xc178);
            public static FormLink<ISpellGetter> ASX_LightArmorGauntletsMovementSpeedPenaltyAbility3    => ModKey.MakeFormKey(0xc17a);
            public static FormLink<ISpellGetter> ASX_LightArmorGauntletsMovementSpeedPenaltyAbility4    => ModKey.MakeFormKey(0xc17c);
            
            public static FormLink<ISpellGetter> ASX_LightArmorGauntletsRangedSpeedPenaltyAbility1      => ModKey.MakeFormKey(0xc10e);
            public static FormLink<ISpellGetter> ASX_LightArmorGauntletsRangedSpeedPenaltyAbility2      => ModKey.MakeFormKey(0xc110);
            public static FormLink<ISpellGetter> ASX_LightArmorGauntletsRangedSpeedPenaltyAbility3      => ModKey.MakeFormKey(0xc112);
            public static FormLink<ISpellGetter> ASX_LightArmorGauntletsRangedSpeedPenaltyAbility4      => ModKey.MakeFormKey(0xc114);
            
            public static FormLink<ISpellGetter> ASX_LightArmorGauntletsStaminaRateMultPenaltyAbility1  => ModKey.MakeFormKey(0xc7c6);
            public static FormLink<ISpellGetter> ASX_LightArmorGauntletsStaminaRateMultPenaltyAbility2  => ModKey.MakeFormKey(0xc7c8);
            public static FormLink<ISpellGetter> ASX_LightArmorGauntletsStaminaRateMultPenaltyAbility3  => ModKey.MakeFormKey(0xc7ca);
            public static FormLink<ISpellGetter> ASX_LightArmorGauntletsStaminaRateMultPenaltyAbility4  => ModKey.MakeFormKey(0xc7cc);
            
            public static FormLink<ISpellGetter> ASX_LightArmorBootsAttackSpeedPenaltyAbility1          => ModKey.MakeFormKey(0xbb2e);
            public static FormLink<ISpellGetter> ASX_LightArmorBootsAttackSpeedPenaltyAbility2          => ModKey.MakeFormKey(0xbb30);
            public static FormLink<ISpellGetter> ASX_LightArmorBootsAttackSpeedPenaltyAbility3          => ModKey.MakeFormKey(0xbb32);
            public static FormLink<ISpellGetter> ASX_LightArmorBootsAttackSpeedPenaltyAbility4          => ModKey.MakeFormKey(0xbb34);
            
            public static FormLink<ISpellGetter> ASX_LightArmorBootsMagicaRateMultPenaltyAbility1       => ModKey.MakeFormKey(0xc73c);
            public static FormLink<ISpellGetter> ASX_LightArmorBootsMagicaRateMultPenaltyAbility2       => ModKey.MakeFormKey(0xc73e);
            public static FormLink<ISpellGetter> ASX_LightArmorBootsMagicaRateMultPenaltyAbility3       => ModKey.MakeFormKey(0xc740);
            public static FormLink<ISpellGetter> ASX_LightArmorBootsMagicaRateMultPenaltyAbility4       => ModKey.MakeFormKey(0xc742);
            
            public static FormLink<ISpellGetter> ASX_LightArmorBootsMovementSpeedPenaltyAbility1        => ModKey.MakeFormKey(0xc166);
            public static FormLink<ISpellGetter> ASX_LightArmorBootsMovementSpeedPenaltyAbility2        => ModKey.MakeFormKey(0xc168);
            public static FormLink<ISpellGetter> ASX_LightArmorBootsMovementSpeedPenaltyAbility3        => ModKey.MakeFormKey(0xc16a);
            public static FormLink<ISpellGetter> ASX_LightArmorBootsMovementSpeedPenaltyAbility4        => ModKey.MakeFormKey(0xc16c);
            
            public static FormLink<ISpellGetter> ASX_LightArmorBootsRangedSpeedPenaltyAbility1          => ModKey.MakeFormKey(0xc0fe);
            public static FormLink<ISpellGetter> ASX_LightArmorBootsRangedSpeedPenaltyAbility2          => ModKey.MakeFormKey(0xc100);
            public static FormLink<ISpellGetter> ASX_LightArmorBootsRangedSpeedPenaltyAbility3          => ModKey.MakeFormKey(0xc102);
            public static FormLink<ISpellGetter> ASX_LightArmorBootsRangedSpeedPenaltyAbility4          => ModKey.MakeFormKey(0xc104);
            
            public static FormLink<ISpellGetter> ASX_LightArmorBootsStaminaRateMultPenaltyAbility1      => ModKey.MakeFormKey(0xc7b6);
            public static FormLink<ISpellGetter> ASX_LightArmorBootsStaminaRateMultPenaltyAbility2      => ModKey.MakeFormKey(0xc7b8);
            public static FormLink<ISpellGetter> ASX_LightArmorBootsStaminaRateMultPenaltyAbility3      => ModKey.MakeFormKey(0xc7ba);
            public static FormLink<ISpellGetter> ASX_LightArmorBootsStaminaRateMultPenaltyAbility4      => ModKey.MakeFormKey(0xc7bc);
            
            public static FormLink<ISpellGetter> ASX_LightArmorCuirassAttackSpeedPenaltyAbility1        => ModKey.MakeFormKey(0xbb36);
            public static FormLink<ISpellGetter> ASX_LightArmorCuirassAttackSpeedPenaltyAbility2        => ModKey.MakeFormKey(0xbb38);
            public static FormLink<ISpellGetter> ASX_LightArmorCuirassAttackSpeedPenaltyAbility3        => ModKey.MakeFormKey(0xbb3a);
            public static FormLink<ISpellGetter> ASX_LightArmorCuirassAttackSpeedPenaltyAbility4        => ModKey.MakeFormKey(0xbb3c);
            
            public static FormLink<ISpellGetter> ASX_LightArmorCuirassMagicaRateMultPenaltyAbility1     => ModKey.MakeFormKey(0xc744);
            public static FormLink<ISpellGetter> ASX_LightArmorCuirassMagicaRateMultPenaltyAbility2     => ModKey.MakeFormKey(0xc746);
            public static FormLink<ISpellGetter> ASX_LightArmorCuirassMagicaRateMultPenaltyAbility3     => ModKey.MakeFormKey(0xc748);
            public static FormLink<ISpellGetter> ASX_LightArmorCuirassMagicaRateMultPenaltyAbility4     => ModKey.MakeFormKey(0xc74a);
            
            public static FormLink<ISpellGetter> ASX_LightArmorCuirassMovementSpeedPenaltyAbility1      => ModKey.MakeFormKey(0xc16e);
            public static FormLink<ISpellGetter> ASX_LightArmorCuirassMovementSpeedPenaltyAbility2      => ModKey.MakeFormKey(0xc170);
            public static FormLink<ISpellGetter> ASX_LightArmorCuirassMovementSpeedPenaltyAbility3      => ModKey.MakeFormKey(0xc172);
            public static FormLink<ISpellGetter> ASX_LightArmorCuirassMovementSpeedPenaltyAbility4      => ModKey.MakeFormKey(0xc174);
            
            public static FormLink<ISpellGetter> ASX_LightArmorCuirassRangedSpeedPenaltyAbility1        => ModKey.MakeFormKey(0xc106);
            public static FormLink<ISpellGetter> ASX_LightArmorCuirassRangedSpeedPenaltyAbility2        => ModKey.MakeFormKey(0xc108);
            public static FormLink<ISpellGetter> ASX_LightArmorCuirassRangedSpeedPenaltyAbility3        => ModKey.MakeFormKey(0xc10a);
            public static FormLink<ISpellGetter> ASX_LightArmorCuirassRangedSpeedPenaltyAbility4        => ModKey.MakeFormKey(0xc10c);
            
            public static FormLink<ISpellGetter> ASX_LightArmorCuirassStaminaRateMultPenaltyAbility1    => ModKey.MakeFormKey(0xc7be);
            public static FormLink<ISpellGetter> ASX_LightArmorCuirassStaminaRateMultPenaltyAbility2    => ModKey.MakeFormKey(0xc7c0);
            public static FormLink<ISpellGetter> ASX_LightArmorCuirassStaminaRateMultPenaltyAbility3    => ModKey.MakeFormKey(0xc7c2);
            public static FormLink<ISpellGetter> ASX_LightArmorCuirassStaminaRateMultPenaltyAbility4    => ModKey.MakeFormKey(0xc7c4);
            
            public static FormLink<ISpellGetter> ASX_LightArmorHelmetAttackSpeedPenaltyAbility1         => ModKey.MakeFormKey(0xbb46);
            public static FormLink<ISpellGetter> ASX_LightArmorHelmetAttackSpeedPenaltyAbility2         => ModKey.MakeFormKey(0xbb48);
            public static FormLink<ISpellGetter> ASX_LightArmorHelmetAttackSpeedPenaltyAbility3         => ModKey.MakeFormKey(0xbb4a);
            public static FormLink<ISpellGetter> ASX_LightArmorHelmetAttackSpeedPenaltyAbility4         => ModKey.MakeFormKey(0xbb4c);
            
            public static FormLink<ISpellGetter> ASX_LightArmorHelmetMagicaRateMultPenaltyAbility1      => ModKey.MakeFormKey(0xc754);
            public static FormLink<ISpellGetter> ASX_LightArmorHelmetMagicaRateMultPenaltyAbility2      => ModKey.MakeFormKey(0xc756);
            public static FormLink<ISpellGetter> ASX_LightArmorHelmetMagicaRateMultPenaltyAbility3      => ModKey.MakeFormKey(0xc758);
            public static FormLink<ISpellGetter> ASX_LightArmorHelmetMagicaRateMultPenaltyAbility4      => ModKey.MakeFormKey(0xc75a);
            
            public static FormLink<ISpellGetter> ASX_LightArmorHelmetMovementSpeedPenaltyAbility1       => ModKey.MakeFormKey(0xc17e);
            public static FormLink<ISpellGetter> ASX_LightArmorHelmetMovementSpeedPenaltyAbility2       => ModKey.MakeFormKey(0xc180);
            public static FormLink<ISpellGetter> ASX_LightArmorHelmetMovementSpeedPenaltyAbility3       => ModKey.MakeFormKey(0xc182);
            public static FormLink<ISpellGetter> ASX_LightArmorHelmetMovementSpeedPenaltyAbility4       => ModKey.MakeFormKey(0xc184);
            
            public static FormLink<ISpellGetter> ASX_LightArmorHelmetRangedSpeedPenaltyAbility1         => ModKey.MakeFormKey(0xc116);
            public static FormLink<ISpellGetter> ASX_LightArmorHelmetRangedSpeedPenaltyAbility2         => ModKey.MakeFormKey(0xc118);
            public static FormLink<ISpellGetter> ASX_LightArmorHelmetRangedSpeedPenaltyAbility3         => ModKey.MakeFormKey(0xc11a);
            public static FormLink<ISpellGetter> ASX_LightArmorHelmetRangedSpeedPenaltyAbility4         => ModKey.MakeFormKey(0xc11c);
            
            public static FormLink<ISpellGetter> ASX_LightArmorHelmetStaminaRateMultPenaltyAbility1     => ModKey.MakeFormKey(0xc7ce);
            public static FormLink<ISpellGetter> ASX_LightArmorHelmetStaminaRateMultPenaltyAbility2     => ModKey.MakeFormKey(0xc7d0);
            public static FormLink<ISpellGetter> ASX_LightArmorHelmetStaminaRateMultPenaltyAbility3     => ModKey.MakeFormKey(0xc7d2);
            public static FormLink<ISpellGetter> ASX_LightArmorHelmetStaminaRateMultPenaltyAbility4     => ModKey.MakeFormKey(0xc7d4);
            
            /***********************************************************Heavy********************************************************/

            public static FormLink<ISpellGetter> ASX_HeavyArmorBootsAttackSpeedPenaltyAbility1          => ModKey.MakeFormKey(0xb040);
            public static FormLink<ISpellGetter> ASX_HeavyArmorBootsAttackSpeedPenaltyAbility2          => ModKey.MakeFormKey(0xb049);
            public static FormLink<ISpellGetter> ASX_HeavyArmorBootsAttackSpeedPenaltyAbility3          => ModKey.MakeFormKey(0xb04a);
            public static FormLink<ISpellGetter> ASX_HeavyArmorBootsAttackSpeedPenaltyAbility4          => ModKey.MakeFormKey(0xb04c);
            
            public static FormLink<ISpellGetter> ASX_HeavyArmorBootsMagickaRateMultPenaltyAbility1      => ModKey.MakeFormKey(0xc717);
            public static FormLink<ISpellGetter> ASX_HeavyArmorBootsMagickaRateMultPenaltyAbility2      => ModKey.MakeFormKey(0xc718);
            public static FormLink<ISpellGetter> ASX_HeavyArmorBootsMagickaRateMultPenaltyAbility3      => ModKey.MakeFormKey(0xc71a);
            public static FormLink<ISpellGetter> ASX_HeavyArmorBootsMagickaRateMultPenaltyAbility4      => ModKey.MakeFormKey(0xc71c);
            
            public static FormLink<ISpellGetter> ASX_HeavyArmorBootsMovementSpeedPenaltyAbility1        => ModKey.MakeFormKey(0xc13e);
            public static FormLink<ISpellGetter> ASX_HeavyArmorBootsMovementSpeedPenaltyAbility2        => ModKey.MakeFormKey(0xc140);
            public static FormLink<ISpellGetter> ASX_HeavyArmorBootsMovementSpeedPenaltyAbility3        => ModKey.MakeFormKey(0xc142);
            public static FormLink<ISpellGetter> ASX_HeavyArmorBootsMovementSpeedPenaltyAbility4        => ModKey.MakeFormKey(0xc144);
            
            public static FormLink<ISpellGetter> ASX_HeavyArmorBootsRangedSpeedPenaltyAbility1          => ModKey.MakeFormKey(0xc0de);
            public static FormLink<ISpellGetter> ASX_HeavyArmorBootsRangedSpeedPenaltyAbility2          => ModKey.MakeFormKey(0xc0e0);
            public static FormLink<ISpellGetter> ASX_HeavyArmorBootsRangedSpeedPenaltyAbility3          => ModKey.MakeFormKey(0xc0e2);
            public static FormLink<ISpellGetter> ASX_HeavyArmorBootsRangedSpeedPenaltyAbility4          => ModKey.MakeFormKey(0xc0e4);
            
            public static FormLink<ISpellGetter> ASX_HeavyArmorBootsStaminaRateMultPenaltyAbility1      => ModKey.MakeFormKey(0xc78c);
            public static FormLink<ISpellGetter> ASX_HeavyArmorBootsStaminaRateMultPenaltyAbility2      => ModKey.MakeFormKey(0xc78e);
            public static FormLink<ISpellGetter> ASX_HeavyArmorBootsStaminaRateMultPenaltyAbility3      => ModKey.MakeFormKey(0xc790);
            public static FormLink<ISpellGetter> ASX_HeavyArmorBootsStaminaRateMultPenaltyAbility4      => ModKey.MakeFormKey(0xc792);
            
            public static FormLink<ISpellGetter> ASX_HeavyArmorCuirassAttackSpeedPenaltyAbility1        => ModKey.MakeFormKey(0xb5af);
            public static FormLink<ISpellGetter> ASX_HeavyArmorCuirassAttackSpeedPenaltyAbility2        => ModKey.MakeFormKey(0xbb11);
            public static FormLink<ISpellGetter> ASX_HeavyArmorCuirassAttackSpeedPenaltyAbility3        => ModKey.MakeFormKey(0xbb12);
            public static FormLink<ISpellGetter> ASX_HeavyArmorCuirassAttackSpeedPenaltyAbility4        => ModKey.MakeFormKey(0xbb14);
            
            public static FormLink<ISpellGetter> ASX_HeavyArmorCuirassMagickaRateMultPenaltyAbility1    => ModKey.MakeFormKey(0xc71e);
            public static FormLink<ISpellGetter> ASX_HeavyArmorCuirassMagickaRateMultPenaltyAbility2    => ModKey.MakeFormKey(0xc720);
            public static FormLink<ISpellGetter> ASX_HeavyArmorCuirassMagickaRateMultPenaltyAbility3    => ModKey.MakeFormKey(0xc722);
            public static FormLink<ISpellGetter> ASX_HeavyArmorCuirassMagickaRateMultPenaltyAbility4    => ModKey.MakeFormKey(0xc724);
            
            public static FormLink<ISpellGetter> ASX_HeavyArmorCuirassMovementSpeedPenaltyAbility1      => ModKey.MakeFormKey(0xc146);
            public static FormLink<ISpellGetter> ASX_HeavyArmorCuirassMovementSpeedPenaltyAbility2      => ModKey.MakeFormKey(0xc148);
            public static FormLink<ISpellGetter> ASX_HeavyArmorCuirassMovementSpeedPenaltyAbility3      => ModKey.MakeFormKey(0xc14a);
            public static FormLink<ISpellGetter> ASX_HeavyArmorCuirassMovementSpeedPenaltyAbility4      => ModKey.MakeFormKey(0xc14c);
            
            public static FormLink<ISpellGetter> ASX_HeavyArmorCuirassRangedSpeedPenaltyAbility1        => ModKey.MakeFormKey(0xc0e6);
            public static FormLink<ISpellGetter> ASX_HeavyArmorCuirassRangedSpeedPenaltyAbility2        => ModKey.MakeFormKey(0xc0e8);
            public static FormLink<ISpellGetter> ASX_HeavyArmorCuirassRangedSpeedPenaltyAbility3        => ModKey.MakeFormKey(0xc0ea);
            public static FormLink<ISpellGetter> ASX_HeavyArmorCuirassRangedSpeedPenaltyAbility4        => ModKey.MakeFormKey(0xc0ec);
            
            public static FormLink<ISpellGetter> ASX_HeavyArmorCuirassStaminaRateMultPenaltyAbility1    => ModKey.MakeFormKey(0xc794);
            public static FormLink<ISpellGetter> ASX_HeavyArmorCuirassStaminaRateMultPenaltyAbility2    => ModKey.MakeFormKey(0xc796);
            public static FormLink<ISpellGetter> ASX_HeavyArmorCuirassStaminaRateMultPenaltyAbility3    => ModKey.MakeFormKey(0xc798);
            public static FormLink<ISpellGetter> ASX_HeavyArmorCuirassStaminaRateMultPenaltyAbility4    => ModKey.MakeFormKey(0xc79a);
            
            public static FormLink<ISpellGetter> ASX_HeavyArmorGauntletsAttackSpeedPenaltyAbility1      => ModKey.MakeFormKey(0xbb16);
            public static FormLink<ISpellGetter> ASX_HeavyArmorGauntletsAttackSpeedPenaltyAbility2      => ModKey.MakeFormKey(0xbb18);
            public static FormLink<ISpellGetter> ASX_HeavyArmorGauntletsAttackSpeedPenaltyAbility3      => ModKey.MakeFormKey(0xbb1a);
            public static FormLink<ISpellGetter> ASX_HeavyArmorGauntletsAttackSpeedPenaltyAbility4      => ModKey.MakeFormKey(0xbb1c);
            
            public static FormLink<ISpellGetter> ASX_HeavyArmorGauntletsMovementSpeedPenaltyAbility1    => ModKey.MakeFormKey(0xc14e);
            public static FormLink<ISpellGetter> ASX_HeavyArmorGauntletsMovementSpeedPenaltyAbility2    => ModKey.MakeFormKey(0xc150);
            public static FormLink<ISpellGetter> ASX_HeavyArmorGauntletsMovementSpeedPenaltyAbility3    => ModKey.MakeFormKey(0xc152);
            public static FormLink<ISpellGetter> ASX_HeavyArmorGauntletsMovementSpeedPenaltyAbility4    => ModKey.MakeFormKey(0xc154);
            
            public static FormLink<ISpellGetter> ASX_HeavyArmorGauntletsRangedSpeedPenaltyAbility1      => ModKey.MakeFormKey(0xc0ee);
            public static FormLink<ISpellGetter> ASX_HeavyArmorGauntletsRangedSpeedPenaltyAbility2      => ModKey.MakeFormKey(0xc0f0);
            public static FormLink<ISpellGetter> ASX_HeavyArmorGauntletsRangedSpeedPenaltyAbility3      => ModKey.MakeFormKey(0xc0f2);
            public static FormLink<ISpellGetter> ASX_HeavyArmorGauntletsRangedSpeedPenaltyAbility4      => ModKey.MakeFormKey(0xc0f4);
            
            public static FormLink<ISpellGetter> ASX_HeavyArmorGlovesMagickaRateMultPenaltyAbility1     => ModKey.MakeFormKey(0xc726);
            public static FormLink<ISpellGetter> ASX_HeavyArmorGlovesMagickaRateMultPenaltyAbility2     => ModKey.MakeFormKey(0xc728);
            public static FormLink<ISpellGetter> ASX_HeavyArmorGlovesMagickaRateMultPenaltyAbility3     => ModKey.MakeFormKey(0xc72a);
            public static FormLink<ISpellGetter> ASX_HeavyArmorGlovesMagickaRateMultPenaltyAbility4     => ModKey.MakeFormKey(0xc79c);
            
            public static FormLink<ISpellGetter> ASX_HeavyArmorGlovesStaminaRateMultPenaltyAbility1     => ModKey.MakeFormKey(0xc79e);
            public static FormLink<ISpellGetter> ASX_HeavyArmorGlovesStaminaRateMultPenaltyAbility2     => ModKey.MakeFormKey(0xc7a0);
            public static FormLink<ISpellGetter> ASX_HeavyArmorGlovesStaminaRateMultPenaltyAbility3     => ModKey.MakeFormKey(0xc7a2);
            public static FormLink<ISpellGetter> ASX_HeavyArmorGlovesStaminaRateMultPenaltyAbility4     => ModKey.MakeFormKey(0xc7a4);
            
            public static FormLink<ISpellGetter> ASX_HeavyArmorHelmetAttackSpeedPenaltyAbility1         => ModKey.MakeFormKey(0xbb1e);
            public static FormLink<ISpellGetter> ASX_HeavyArmorHelmetAttackSpeedPenaltyAbility2         => ModKey.MakeFormKey(0xbb20);
            public static FormLink<ISpellGetter> ASX_HeavyArmorHelmetAttackSpeedPenaltyAbility3         => ModKey.MakeFormKey(0xbb22);
            public static FormLink<ISpellGetter> ASX_HeavyArmorHelmetAttackSpeedPenaltyAbility4         => ModKey.MakeFormKey(0xbb24);
            
            public static FormLink<ISpellGetter> ASX_HeavyArmorHelmetMagickaRateMultPenaltyAbility1     => ModKey.MakeFormKey(0xc72c);
            public static FormLink<ISpellGetter> ASX_HeavyArmorHelmetMagickaRateMultPenaltyAbility2     => ModKey.MakeFormKey(0xc72e);
            public static FormLink<ISpellGetter> ASX_HeavyArmorHelmetMagickaRateMultPenaltyAbility3     => ModKey.MakeFormKey(0xc730);
            public static FormLink<ISpellGetter> ASX_HeavyArmorHelmetMagickaRateMultPenaltyAbility4     => ModKey.MakeFormKey(0xc732);
            
            public static FormLink<ISpellGetter> ASX_HeavyArmorHelmetMovementSpeedPenaltyAbility1       => ModKey.MakeFormKey(0xc156);
            public static FormLink<ISpellGetter> ASX_HeavyArmorHelmetMovementSpeedPenaltyAbility2       => ModKey.MakeFormKey(0xc158);
            public static FormLink<ISpellGetter> ASX_HeavyArmorHelmetMovementSpeedPenaltyAbility3       => ModKey.MakeFormKey(0xc15a);
            public static FormLink<ISpellGetter> ASX_HeavyArmorHelmetMovementSpeedPenaltyAbility4       => ModKey.MakeFormKey(0xc15c);
            
            public static FormLink<ISpellGetter> ASX_HeavyArmorHelmetRangedSpeedPenaltyAbility1         => ModKey.MakeFormKey(0xc0f6);
            public static FormLink<ISpellGetter> ASX_HeavyArmorHelmetRangedSpeedPenaltyAbility2         => ModKey.MakeFormKey(0xc0f8);
            public static FormLink<ISpellGetter> ASX_HeavyArmorHelmetRangedSpeedPenaltyAbility3         => ModKey.MakeFormKey(0xc0fa);
            public static FormLink<ISpellGetter> ASX_HeavyArmorHelmetRangedSpeedPenaltyAbility4         => ModKey.MakeFormKey(0xc0fc);
            
            public static FormLink<ISpellGetter> ASX_HeavyArmorHelmetStaminaRateMultPenaltyAbility1     => ModKey.MakeFormKey(0xc7a6);
            public static FormLink<ISpellGetter> ASX_HeavyArmorHelmetStaminaRateMultPenaltyAbility2     => ModKey.MakeFormKey(0xc7a8);
            public static FormLink<ISpellGetter> ASX_HeavyArmorHelmetStaminaRateMultPenaltyAbility3     => ModKey.MakeFormKey(0xc7aa);
            public static FormLink<ISpellGetter> ASX_HeavyArmorHelmetStaminaRateMultPenaltyAbility4     => ModKey.MakeFormKey(0xc7ac);
            
            public static FormLink<ISpellGetter> ASX_HeavyArmorShieldAttackSpeedPenaltyAbility1         => ModKey.MakeFormKey(0xbb26);
            public static FormLink<ISpellGetter> ASX_HeavyArmorShieldAttackSpeedPenaltyAbility2         => ModKey.MakeFormKey(0xbb28);
            public static FormLink<ISpellGetter> ASX_HeavyArmorShieldAttackSpeedPenaltyAbility3         => ModKey.MakeFormKey(0xbb2a);
            public static FormLink<ISpellGetter> ASX_HeavyArmorShieldAttackSpeedPenaltyAbility4         => ModKey.MakeFormKey(0xbb2c);
            
            public static FormLink<ISpellGetter> ASX_HeavyArmorShieldMagickaRateMultPenaltyAbility1     => ModKey.MakeFormKey(0xc734);
            public static FormLink<ISpellGetter> ASX_HeavyArmorShieldMagickaRateMultPenaltyAbility2     => ModKey.MakeFormKey(0xc736);
            public static FormLink<ISpellGetter> ASX_HeavyArmorShieldMagickaRateMultPenaltyAbility3     => ModKey.MakeFormKey(0xc738);
            public static FormLink<ISpellGetter> ASX_HeavyArmorShieldMagickaRateMultPenaltyAbility4     => ModKey.MakeFormKey(0xc73a);
            
            public static FormLink<ISpellGetter> ASX_HeavyArmorShieldMovementSpeedPenaltyAbility1       => ModKey.MakeFormKey(0xc15e);
            public static FormLink<ISpellGetter> ASX_HeavyArmorShieldMovementSpeedPenaltyAbility2       => ModKey.MakeFormKey(0xc160);
            public static FormLink<ISpellGetter> ASX_HeavyArmorShieldMovementSpeedPenaltyAbility3       => ModKey.MakeFormKey(0xc162);
            public static FormLink<ISpellGetter> ASX_HeavyArmorShieldMovementSpeedPenaltyAbility4       => ModKey.MakeFormKey(0xc164);
            
            public static FormLink<ISpellGetter> ASX_HeavyArmorShieldStaminaRateMultPenaltyAbility1     => ModKey.MakeFormKey(0xc7ae);
            public static FormLink<ISpellGetter> ASX_HeavyArmorShieldStaminaRateMultPenaltyAbility2     => ModKey.MakeFormKey(0xc7b0);
            public static FormLink<ISpellGetter> ASX_HeavyArmorShieldStaminaRateMultPenaltyAbility3     => ModKey.MakeFormKey(0xc7b2);
            public static FormLink<ISpellGetter> ASX_HeavyArmorShieldStaminaRateMultPenaltyAbility4     => ModKey.MakeFormKey(0xc7b4);

            /********************************************************************Passives***********************************************************************************/

            public static FormLink<ISpellGetter> ASX_AlterationMagickaRegenAbility  => ModKey.MakeFormKey(0x28c4);
            public static FormLink<ISpellGetter> ASX_ConjurationMagickaRegenAbility => ModKey.MakeFormKey(0x28c2);
            public static FormLink<ISpellGetter> ASX_DestructionMagickaRegenAbility => ModKey.MakeFormKey(0x28c0);
            public static FormLink<ISpellGetter> ASX_RestorationMagickaRegenAbility => ModKey.MakeFormKey(0x28c8);
            public static FormLink<ISpellGetter> ASX_IllusionMagickaRegenAbility    => ModKey.MakeFormKey(0x28c6);

            public static FormLink<ISpellGetter> ASX_ArcheryAttackSpeedBoostAbility1   => ModKey.MakeFormKey(0x6f77);
            public static FormLink<ISpellGetter> ASX_ArcheryAttackSpeedBoostAbility2   => ModKey.MakeFormKey(0x6f79);
            public static FormLink<ISpellGetter> ASX_ArcheryAttackSpeedBoostAbility3   => ModKey.MakeFormKey(0x6f7b);
            public static FormLink<ISpellGetter> ASX_ArcheryAttackSpeedBoostAbility4   => ModKey.MakeFormKey(0x6f7d);

            public static FormLink<ISpellGetter> ASX_OneHandedAttackSpeedBoostAbility1 => ModKey.MakeFormKey(0x6f68);
            public static FormLink<ISpellGetter> ASX_OneHandedAttackSpeedBoostAbility2 => ModKey.MakeFormKey(0x6f69);
            public static FormLink<ISpellGetter> ASX_OneHandedAttackSpeedBoostAbility3 => ModKey.MakeFormKey(0x6f6b);
            public static FormLink<ISpellGetter> ASX_OneHandedAttackSpeedBoostAbility4 => ModKey.MakeFormKey(0x6f6d);
            
            public static FormLink<ISpellGetter> ASX_TwoHandedAttackSpeedBoostAbility1 => ModKey.MakeFormKey(0x6f6f);
            public static FormLink<ISpellGetter> ASX_TwoHandedAttackSpeedBoostAbility2 => ModKey.MakeFormKey(0x6f71);
            public static FormLink<ISpellGetter> ASX_TwoHandedAttackSpeedBoostAbility3 => ModKey.MakeFormKey(0x6f73);
            public static FormLink<ISpellGetter> ASX_TwoHandedAttackSpeedBoostAbility4 => ModKey.MakeFormKey(0x6f75);

            public static FormLink<ISpellGetter> ASX_LightArmorStaminaRateMultBoost => ModKey.MakeFormKey(0x28cc);
            public static FormLink<ISpellGetter> ASX_HeavyArmorStaminaRateMultBoost => ModKey.MakeFormKey(0x33a9);

            public static FormLink<ISpellGetter> ASX_LightArmorMoveSpeedBoostSplitAbility => ModKey.MakeFormKey(0xD82B);
            public static FormLink<ISpellGetter> ASX_HeavyArmorMoveSpeedBoostNewAbility => ModKey.MakeFormKey(0xD82C);


            public static readonly List<FormLink<ISpellGetter>> ArcheryBoosts = new() { ASX_ArcheryAttackSpeedBoostAbility1, ASX_ArcheryAttackSpeedBoostAbility2, ASX_ArcheryAttackSpeedBoostAbility3, ASX_ArcheryAttackSpeedBoostAbility4 };
            public static readonly List<FormLink<ISpellGetter>> OneHandedBoosts = new() { ASX_OneHandedAttackSpeedBoostAbility1, ASX_OneHandedAttackSpeedBoostAbility2, ASX_OneHandedAttackSpeedBoostAbility3, ASX_OneHandedAttackSpeedBoostAbility4 };
            public static readonly List<FormLink<ISpellGetter>> TwoHandedBoosts = new() { ASX_TwoHandedAttackSpeedBoostAbility1, ASX_TwoHandedAttackSpeedBoostAbility2, ASX_TwoHandedAttackSpeedBoostAbility3, ASX_TwoHandedAttackSpeedBoostAbility4 };





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

    }
}