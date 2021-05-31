using System;
using System.Collections.Generic;
using Mutagen.Bethesda;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace ActionSpeedX
{
    public static partial class FormKeys
    {
        public static class Keywords
        {
            private static readonly ModKey ModKey                             = ModKey.FromNameAndExtension("ActionSpeedX.esp");
            private static FormLink<IKeywordGetter> ASX_LightArmorBootsT1     => ModKey.MakeFormKey(0x00182F);
            private static FormLink<IKeywordGetter> ASX_LightArmorBootsT2     => ModKey.MakeFormKey(0x001831);
            private static FormLink<IKeywordGetter> ASX_LightArmorBootsT3     => ModKey.MakeFormKey(0x001832);
            private static FormLink<IKeywordGetter> ASX_LightArmorBootsT4     => ModKey.MakeFormKey(0x001833);
            private static FormLink<IKeywordGetter> ASX_LightArmorCuirassT1   => ModKey.MakeFormKey(0x001834);
            private static FormLink<IKeywordGetter> ASX_LightArmorCuirassT2   => ModKey.MakeFormKey(0x001835);
            private static FormLink<IKeywordGetter> ASX_LightArmorCuirassT3   => ModKey.MakeFormKey(0x001836);
            private static FormLink<IKeywordGetter> ASX_LightArmorCuirassT4   => ModKey.MakeFormKey(0x001837);
            private static FormLink<IKeywordGetter> ASX_LightArmorHelmetT1    => ModKey.MakeFormKey(0x001838);
            private static FormLink<IKeywordGetter> ASX_LightArmorHelmetT2    => ModKey.MakeFormKey(0x001839);
            private static FormLink<IKeywordGetter> ASX_LightArmorHelmetT3    => ModKey.MakeFormKey(0x00183A);
            private static FormLink<IKeywordGetter> ASX_LightArmorHelmetT4    => ModKey.MakeFormKey(0x00183B);
            private static FormLink<IKeywordGetter> ASX_LightArmorGauntletsT1 => ModKey.MakeFormKey(0x00183C);
            private static FormLink<IKeywordGetter> ASX_LightArmorGauntletsT2 => ModKey.MakeFormKey(0x00183D);
            private static FormLink<IKeywordGetter> ASX_LightArmorGauntletsT3 => ModKey.MakeFormKey(0x00183E);
            private static FormLink<IKeywordGetter> ASX_LightArmorGauntletsT4 => ModKey.MakeFormKey(0x00183F);
            private static FormLink<IKeywordGetter> ASX_LightArmorShieldT1    => ModKey.MakeFormKey(0x001840);
            private static FormLink<IKeywordGetter> ASX_LightArmorShieldT2    => ModKey.MakeFormKey(0x001841);
            private static FormLink<IKeywordGetter> ASX_LightArmorShieldT3    => ModKey.MakeFormKey(0x001842);
            private static FormLink<IKeywordGetter> ASX_LightArmorShieldT4    => ModKey.MakeFormKey(0x001843);

            private static FormLink<IKeywordGetter> ASX_HeavyArmorBootsT1     => ModKey.MakeFormKey(0x001844);
            private static FormLink<IKeywordGetter> ASX_HeavyArmorBootsT2     => ModKey.MakeFormKey(0x001845);
            private static FormLink<IKeywordGetter> ASX_HeavyArmorBootsT3     => ModKey.MakeFormKey(0x001846);
            private static FormLink<IKeywordGetter> ASX_HeavyArmorBootsT4     => ModKey.MakeFormKey(0x001847);
            private static FormLink<IKeywordGetter> ASX_HeavyArmorCuirassT1   => ModKey.MakeFormKey(0x001848);
            private static FormLink<IKeywordGetter> ASX_HeavyArmorCuirassT4   => ModKey.MakeFormKey(0x001849);
            private static FormLink<IKeywordGetter> ASX_HeavyArmorCuirassT2   => ModKey.MakeFormKey(0x00184A);
            private static FormLink<IKeywordGetter> ASX_HeavyArmorCuirassT3   => ModKey.MakeFormKey(0x00184B);
            private static FormLink<IKeywordGetter> ASX_HeavyArmorHelmetT1    => ModKey.MakeFormKey(0x00184C);
            private static FormLink<IKeywordGetter> ASX_HeavyArmorHelmetT2    => ModKey.MakeFormKey(0x00184D);
            private static FormLink<IKeywordGetter> ASX_HeavyArmorHelmetT3    => ModKey.MakeFormKey(0x00184E);
            private static FormLink<IKeywordGetter> ASX_HeavyArmorHelmetT4    => ModKey.MakeFormKey(0x00184F);
            private static FormLink<IKeywordGetter> ASX_HeavyArmorGauntletsT1 => ModKey.MakeFormKey(0x001850);
            private static FormLink<IKeywordGetter> ASX_HeavyArmorGauntletsT2 => ModKey.MakeFormKey(0x001851);
            private static FormLink<IKeywordGetter> ASX_HeavyArmorGauntletsT3 => ModKey.MakeFormKey(0x001852);
            private static FormLink<IKeywordGetter> ASX_HeavyArmorGauntletsT4 => ModKey.MakeFormKey(0x001853);
            private static FormLink<IKeywordGetter> ASX_HeavyArmorShieldT1    => ModKey.MakeFormKey(0x001854);
            private static FormLink<IKeywordGetter> ASX_HeavyArmorShieldT2    => ModKey.MakeFormKey(0x001855);
            private static FormLink<IKeywordGetter> ASX_HeavyArmorShieldT3    => ModKey.MakeFormKey(0x001856);
            private static FormLink<IKeywordGetter> ASX_HeavyArmorShieldT4    => ModKey.MakeFormKey(0x001857);

            /*
            private static FormLink<IKeywordGetter> ASX_MediumArmorBootsT1     => ModKey.MakeFormKey(0x003EA6);
            private static FormLink<IKeywordGetter> ASX_MediumArmorBootsT2     => ModKey.MakeFormKey(0x003EA7);
            private static FormLink<IKeywordGetter> ASX_MediumArmorBootsT3     => ModKey.MakeFormKey(0x003EA8);
            private static FormLink<IKeywordGetter> ASX_MediumArmorBootsT4     => ModKey.MakeFormKey(0x003EA9);
            private static FormLink<IKeywordGetter> ASX_MediumArmorCuirassT1   => ModKey.MakeFormKey(0x003EAA);
            private static FormLink<IKeywordGetter> ASX_MediumArmorCuirassT2   => ModKey.MakeFormKey(0x003EAB);
            private static FormLink<IKeywordGetter> ASX_MediumArmorCuirassT3   => ModKey.MakeFormKey(0x003EAC);
            private static FormLink<IKeywordGetter> ASX_MediumArmorCuirassT4   => ModKey.MakeFormKey(0x003EAD);
            private static FormLink<IKeywordGetter> ASX_MediumArmorGauntletsT1 => ModKey.MakeFormKey(0x003EAE);
            private static FormLink<IKeywordGetter> ASX_MediumArmorGauntletsT2 => ModKey.MakeFormKey(0x003EAF);
            private static FormLink<IKeywordGetter> ASX_MediumArmorGauntletsT3 => ModKey.MakeFormKey(0x003EB0);
            private static FormLink<IKeywordGetter> ASX_MediumArmorGauntletsT4 => ModKey.MakeFormKey(0x003EB1);
            private static FormLink<IKeywordGetter> ASX_MediumArmorHelmetT1    => ModKey.MakeFormKey(0x003EB2);
            private static FormLink<IKeywordGetter> ASX_MediumArmorHelmetT2    => ModKey.MakeFormKey(0x003EB3);
            private static FormLink<IKeywordGetter> ASX_MediumArmorHelmetT3    => ModKey.MakeFormKey(0x003EB4);
            private static FormLink<IKeywordGetter> ASX_MediumArmorHelmetT4    => ModKey.MakeFormKey(0x003EB5);
            private static FormLink<IKeywordGetter> ASX_MediumArmorShieldT1    => ModKey.MakeFormKey(0x003EB6);
            private static FormLink<IKeywordGetter> ASX_MediumArmorShieldT2    => ModKey.MakeFormKey(0x003EB7);
            private static FormLink<IKeywordGetter> ASX_MediumArmorShieldT3    => ModKey.MakeFormKey(0x003EB8);
            private static FormLink<IKeywordGetter> ASX_MediumArmorShieldT4    => ModKey.MakeFormKey(0x003EB9);
            */

            // Light armor keywords that will be added to equipment
            static readonly List<FormLink<IKeywordGetter> > lightBoots     = new() { ASX_LightArmorBootsT1, ASX_LightArmorBootsT2, ASX_LightArmorBootsT3, ASX_LightArmorBootsT4 };
            static readonly List<FormLink<IKeywordGetter> > lightCuirass   = new() { ASX_LightArmorCuirassT1, ASX_LightArmorCuirassT2, ASX_LightArmorCuirassT3, ASX_LightArmorCuirassT4 };
            static readonly List<FormLink<IKeywordGetter> > lightGauntlets = new() { ASX_LightArmorGauntletsT1, ASX_LightArmorGauntletsT2, ASX_LightArmorGauntletsT3, ASX_LightArmorGauntletsT4 };
            static readonly List<FormLink<IKeywordGetter> > lightHelmet    = new() { ASX_LightArmorHelmetT1, ASX_LightArmorHelmetT2, ASX_LightArmorHelmetT3, ASX_LightArmorHelmetT4 };
            static readonly List<FormLink<IKeywordGetter> > lightShield    = new() { ASX_LightArmorShieldT1, ASX_LightArmorShieldT2, ASX_LightArmorShieldT3, ASX_LightArmorShieldT4 };
            public static readonly Dictionary<String, List<FormLink<IKeywordGetter> >> LightArmorKeywordCollection = new Dictionary<string, List<FormLink<IKeywordGetter> >> {
                { "Boots", lightBoots },
                { "Cuirass", lightCuirass },
                { "Gauntlets", lightGauntlets },
                { "Helmet", lightHelmet},
                { "Shield", lightShield}
            };

            // Heavy armor keywords that will be added to equipment
            static readonly List<FormLink<IKeywordGetter> > heavyBoots     = new() { ASX_HeavyArmorBootsT1, ASX_HeavyArmorBootsT2, ASX_HeavyArmorBootsT3, ASX_HeavyArmorBootsT4 };
            static readonly List<FormLink<IKeywordGetter> > heavyCuirass   = new() { ASX_HeavyArmorCuirassT1, ASX_HeavyArmorCuirassT2, ASX_HeavyArmorCuirassT3, ASX_HeavyArmorCuirassT4 };
            static readonly List<FormLink<IKeywordGetter> > heavyGauntlets = new() { ASX_HeavyArmorGauntletsT1, ASX_HeavyArmorGauntletsT2, ASX_HeavyArmorGauntletsT3, ASX_HeavyArmorGauntletsT4 };
            static readonly List<FormLink<IKeywordGetter> > heavyHelmet    = new() { ASX_HeavyArmorHelmetT1, ASX_HeavyArmorHelmetT2, ASX_HeavyArmorHelmetT3, ASX_HeavyArmorHelmetT4 };
            static readonly List<FormLink<IKeywordGetter> > heavyShield    = new() { ASX_HeavyArmorShieldT1, ASX_HeavyArmorShieldT2, ASX_HeavyArmorShieldT3, ASX_HeavyArmorShieldT4 };
            public static readonly Dictionary<String, List<FormLink<IKeywordGetter> >> HeavyArmorKeywordCollection = new Dictionary<string, List<FormLink<IKeywordGetter> >> {
                { "Boots", heavyBoots },
                { "Cuirass", heavyCuirass },
                { "Gauntlets", heavyGauntlets },
                { "Helmet", heavyHelmet},
                { "Shield", heavyShield}
            };

            
            /*
            static readonly List<FormLink<IKeywordGetter> > mediumBoots     = new() { ASX_MediumArmorBootsT1, ASX_MediumArmorBootsT2, ASX_MediumArmorBootsT3, ASX_MediumArmorBootsT4 };
            static readonly List<FormLink<IKeywordGetter> > mediumCuirass   = new() { ASX_MediumArmorCuirassT1, ASX_MediumArmorCuirassT2, ASX_MediumArmorCuirassT3, ASX_MediumArmorCuirassT4 };
            static readonly List<FormLink<IKeywordGetter> > mediumGauntlets = new() { ASX_MediumArmorGauntletsT1, ASX_MediumArmorGauntletsT2, ASX_MediumArmorGauntletsT3, ASX_MediumArmorGauntletsT4 };
            static readonly List<FormLink<IKeywordGetter> > mediumHelmet    = new() { ASX_MediumArmorHelmetT1, ASX_MediumArmorHelmetT2, ASX_MediumArmorHelmetT3, ASX_MediumArmorHelmetT4 };
            static readonly List<FormLink<IKeywordGetter> > mediumShield    = new() { ASX_MediumArmorShieldT1, ASX_MediumArmorShieldT2, ASX_MediumArmorShieldT3, ASX_MediumArmorShieldT4 };
            public static readonly Dictionary<String, List<FormLink<IKeywordGetter> >> mediumArmorKeys = new Dictionary<string, List<FormLink<IKeywordGetter> >> {
                { "Boots", mediumBoots },
                { "Cuirass", mediumCuirass },
                { "Gauntlets", mediumGauntlets },
                { "Helmet", mediumHelmet},
                { "Shield", mediumShield}
            }; 
            */
        }
    }
}