using System;
using System.Collections.Generic;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Plugins;

namespace Mutagen.Bethesda.FormKeys.SkyrimSE
{
    public static partial class ActionSpeedX_
    {
        public static readonly ModKey ModKey_ = ModKey.FromNameAndExtension("ActionSpeedX.esp");
        public static class Keywords
        {
            
            private static FormLink<IKeywordGetter> Construct(uint id) => new(ModKey_.MakeFormKey(id));
            public static FormLink<IKeywordGetter> ASX_LightArmorBootsT1     => Construct(0x00182F);
            public static FormLink<IKeywordGetter> ASX_LightArmorBootsT2     => Construct(0x001831);
            public static FormLink<IKeywordGetter> ASX_LightArmorBootsT3     => Construct(0x001832);
            public static FormLink<IKeywordGetter> ASX_LightArmorBootsT4     => Construct(0x001833);
            public static FormLink<IKeywordGetter> ASX_LightArmorCuirassT1   => Construct(0x001834);
            public static FormLink<IKeywordGetter> ASX_LightArmorCuirassT2   => Construct(0x001835);
            public static FormLink<IKeywordGetter> ASX_LightArmorCuirassT3   => Construct(0x001836);
            public static FormLink<IKeywordGetter> ASX_LightArmorCuirassT4   => Construct(0x001837);
            public static FormLink<IKeywordGetter> ASX_LightArmorHelmetT1    => Construct(0x001838);
            public static FormLink<IKeywordGetter> ASX_LightArmorHelmetT2    => Construct(0x001839);
            public static FormLink<IKeywordGetter> ASX_LightArmorHelmetT3    => Construct(0x00183A);
            public static FormLink<IKeywordGetter> ASX_LightArmorHelmetT4    => Construct(0x00183B);
            public static FormLink<IKeywordGetter> ASX_LightArmorGauntletsT1 => Construct(0x00183C);
            public static FormLink<IKeywordGetter> ASX_LightArmorGauntletsT2 => Construct(0x00183D);
            public static FormLink<IKeywordGetter> ASX_LightArmorGauntletsT3 => Construct(0x00183E);
            public static FormLink<IKeywordGetter> ASX_LightArmorGauntletsT4 => Construct(0x00183F);
            public static FormLink<IKeywordGetter> ASX_LightArmorShieldT1    => Construct(0x001840);
            public static FormLink<IKeywordGetter> ASX_LightArmorShieldT2    => Construct(0x001841);
            public static FormLink<IKeywordGetter> ASX_LightArmorShieldT3    => Construct(0x001842);
            public static FormLink<IKeywordGetter> ASX_LightArmorShieldT4    => Construct(0x001843);

            public static FormLink<IKeywordGetter> ASX_HeavyArmorBootsT1     => Construct(0x001844);
            public static FormLink<IKeywordGetter> ASX_HeavyArmorBootsT2     => Construct(0x001845);
            public static FormLink<IKeywordGetter> ASX_HeavyArmorBootsT3     => Construct(0x001846);
            public static FormLink<IKeywordGetter> ASX_HeavyArmorBootsT4     => Construct(0x001847);
            public static FormLink<IKeywordGetter> ASX_HeavyArmorCuirassT1   => Construct(0x001848);
            public static FormLink<IKeywordGetter> ASX_HeavyArmorCuirassT4   => Construct(0x001849);
            public static FormLink<IKeywordGetter> ASX_HeavyArmorCuirassT2   => Construct(0x00184A);
            public static FormLink<IKeywordGetter> ASX_HeavyArmorCuirassT3   => Construct(0x00184B);
            public static FormLink<IKeywordGetter> ASX_HeavyArmorHelmetT1    => Construct(0x00184C);
            public static FormLink<IKeywordGetter> ASX_HeavyArmorHelmetT2    => Construct(0x00184D);
            public static FormLink<IKeywordGetter> ASX_HeavyArmorHelmetT3    => Construct(0x00184E);
            public static FormLink<IKeywordGetter> ASX_HeavyArmorHelmetT4    => Construct(0x00184F);
            public static FormLink<IKeywordGetter> ASX_HeavyArmorGauntletsT1 => Construct(0x001850);
            public static FormLink<IKeywordGetter> ASX_HeavyArmorGauntletsT2 => Construct(0x001851);
            public static FormLink<IKeywordGetter> ASX_HeavyArmorGauntletsT3 => Construct(0x001852);
            public static FormLink<IKeywordGetter> ASX_HeavyArmorGauntletsT4 => Construct(0x001853);
            public static FormLink<IKeywordGetter> ASX_HeavyArmorShieldT1    => Construct(0x001854);
            public static FormLink<IKeywordGetter> ASX_HeavyArmorShieldT2    => Construct(0x001855);
            public static FormLink<IKeywordGetter> ASX_HeavyArmorShieldT3    => Construct(0x001856);
            public static FormLink<IKeywordGetter> ASX_HeavyArmorShieldT4    => Construct(0x001857);

            /*
            private static FormLink<IKeywordGetter> ASX_MediumArmorBootsT1     => Construct(0x003EA6);
            private static FormLink<IKeywordGetter> ASX_MediumArmorBootsT2     => Construct(0x003EA7);
            private static FormLink<IKeywordGetter> ASX_MediumArmorBootsT3     => Construct(0x003EA8);
            private static FormLink<IKeywordGetter> ASX_MediumArmorBootsT4     => Construct(0x003EA9);
            private static FormLink<IKeywordGetter> ASX_MediumArmorCuirassT1   => Construct(0x003EAA);
            private static FormLink<IKeywordGetter> ASX_MediumArmorCuirassT2   => Construct(0x003EAB);
            private static FormLink<IKeywordGetter> ASX_MediumArmorCuirassT3   => Construct(0x003EAC);
            private static FormLink<IKeywordGetter> ASX_MediumArmorCuirassT4   => Construct(0x003EAD);
            private static FormLink<IKeywordGetter> ASX_MediumArmorGauntletsT1 => Construct(0x003EAE);
            private static FormLink<IKeywordGetter> ASX_MediumArmorGauntletsT2 => Construct(0x003EAF);
            private static FormLink<IKeywordGetter> ASX_MediumArmorGauntletsT3 => Construct(0x003EB0);
            private static FormLink<IKeywordGetter> ASX_MediumArmorGauntletsT4 => Construct(0x003EB1);
            private static FormLink<IKeywordGetter> ASX_MediumArmorHelmetT1    => Construct(0x003EB2);
            private static FormLink<IKeywordGetter> ASX_MediumArmorHelmetT2    => Construct(0x003EB3);
            private static FormLink<IKeywordGetter> ASX_MediumArmorHelmetT3    => Construct(0x003EB4);
            private static FormLink<IKeywordGetter> ASX_MediumArmorHelmetT4    => Construct(0x003EB5);
            private static FormLink<IKeywordGetter> ASX_MediumArmorShieldT1    => Construct(0x003EB6);
            private static FormLink<IKeywordGetter> ASX_MediumArmorShieldT2    => Construct(0x003EB7);
            private static FormLink<IKeywordGetter> ASX_MediumArmorShieldT3    => Construct(0x003EB8);
            private static FormLink<IKeywordGetter> ASX_MediumArmorShieldT4    => Construct(0x003EB9);
            */

            // Light armor keywords that will be added to equipment
            static readonly List<FormLink<IKeywordGetter> > LightBoots     = new() { ASX_LightArmorBootsT1, ASX_LightArmorBootsT2, ASX_LightArmorBootsT3, ASX_LightArmorBootsT4 };
            static readonly List<FormLink<IKeywordGetter> > LightCuirass   = new() { ASX_LightArmorCuirassT1, ASX_LightArmorCuirassT2, ASX_LightArmorCuirassT3, ASX_LightArmorCuirassT4 };
            static readonly List<FormLink<IKeywordGetter> > LightGauntlets = new() { ASX_LightArmorGauntletsT1, ASX_LightArmorGauntletsT2, ASX_LightArmorGauntletsT3, ASX_LightArmorGauntletsT4 };
            static readonly List<FormLink<IKeywordGetter> > LightHelmet    = new() { ASX_LightArmorHelmetT1, ASX_LightArmorHelmetT2, ASX_LightArmorHelmetT3, ASX_LightArmorHelmetT4 };
            static readonly List<FormLink<IKeywordGetter> > LightShield    = new() { ASX_LightArmorShieldT1, ASX_LightArmorShieldT2, ASX_LightArmorShieldT3, ASX_LightArmorShieldT4 };
            public static readonly Dictionary<String, List<FormLink<IKeywordGetter> >> LightArmorKeywordCollection = new Dictionary<string, List<FormLink<IKeywordGetter> >> {
                { "Boots", LightBoots },
                { "Cuirass", LightCuirass },
                { "Gauntlets", LightGauntlets },
                { "Helmet", LightHelmet},
                { "Shield", LightShield}
            };

            // Heavy armor keywords that will be added to equipment
            static readonly List<FormLink<IKeywordGetter> > HeavyBoots     = new() { ASX_HeavyArmorBootsT1, ASX_HeavyArmorBootsT2, ASX_HeavyArmorBootsT3, ASX_HeavyArmorBootsT4 };
            static readonly List<FormLink<IKeywordGetter> > HeavyCuirass   = new() { ASX_HeavyArmorCuirassT1, ASX_HeavyArmorCuirassT2, ASX_HeavyArmorCuirassT3, ASX_HeavyArmorCuirassT4 };
            static readonly List<FormLink<IKeywordGetter> > HeavyGauntlets = new() { ASX_HeavyArmorGauntletsT1, ASX_HeavyArmorGauntletsT2, ASX_HeavyArmorGauntletsT3, ASX_HeavyArmorGauntletsT4 };
            static readonly List<FormLink<IKeywordGetter> > HeavyHelmet    = new() { ASX_HeavyArmorHelmetT1, ASX_HeavyArmorHelmetT2, ASX_HeavyArmorHelmetT3, ASX_HeavyArmorHelmetT4 };
            static readonly List<FormLink<IKeywordGetter> > HeavyShield    = new() { ASX_HeavyArmorShieldT1, ASX_HeavyArmorShieldT2, ASX_HeavyArmorShieldT3, ASX_HeavyArmorShieldT4 };
            public static readonly Dictionary<String, List<FormLink<IKeywordGetter> >> HeavyArmorKeywordCollection = new Dictionary<string, List<FormLink<IKeywordGetter> >> {
                { "Boots", HeavyBoots },
                { "Cuirass", HeavyCuirass },
                { "Gauntlets", HeavyGauntlets },
                { "Helmet", HeavyHelmet},
                { "Shield", HeavyShield}
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