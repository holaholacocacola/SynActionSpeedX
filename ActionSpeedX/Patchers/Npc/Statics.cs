using System.Collections.Generic;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.FormKeys.SkyrimSE;
using Mutagen.Bethesda.Plugins;

namespace ActionSpeedX.Patchers
{
    public static class NpcStatics
    {
        /// <summary>
        /// Contain Relationship between (Class) Skill and Novice Perks related to that skill.
        /// </summary>
        public struct NpcClassSkillPerksMappings
        {
            public Dictionary<Skill, FormLink<IPerkGetter>> StaminaSkillPerks;
            public Dictionary<Skill, FormLink<IPerkGetter>> MagickaSkillPerks;
            public Dictionary<Skill, FormLink<IPerkGetter>> SpeedSkillPerks;
            public Dictionary<Skill, FormLink<IPerkGetter>> AttackSpeedSkillPerks;
            public Dictionary<Skill, FormLink<IPerkGetter>> RangedAttackSkillPerks;
        }


        public static readonly NpcClassSkillPerksMappings VanillaSkillPerkMapping = new()
        {
            StaminaSkillPerks = new()
            {
                { Skill.LightArmor, Skyrim.Perk.AgileDefender00 },
                { Skill.HeavyArmor, Skyrim.Perk.Juggernaut00 }
            },
            MagickaSkillPerks = new()
            {

                { Skill.Alteration, Skyrim.Perk.AlterationNovice00 },
                { Skill.Conjuration, Skyrim.Perk.ConjurationNovice00 },
                { Skill.Destruction, Skyrim.Perk.DestructionNovice00 },
                { Skill.Illusion, Skyrim.Perk.IllusionNovice00 },
                { Skill.Restoration, Skyrim.Perk.RestorationNovice00 },
            },
            SpeedSkillPerks = new()
            {
                { Skill.LightArmor, Skyrim.Perk.AgileDefender00 },
                { Skill.HeavyArmor, Skyrim.Perk.Juggernaut00 }
            },
            AttackSpeedSkillPerks = new()
            {
                { Skill.OneHanded, Skyrim.Perk.Armsman00 },
                { Skill.TwoHanded, Skyrim.Perk.Barbarian00 },
            },
            RangedAttackSkillPerks = new()
            {
                { Skill.Archery, Skyrim.Perk.Overdraw00 }
            }
        };

        public static readonly NpcClassSkillPerksMappings OrdinatorSkillPerkMapping = new()
        {
            StaminaSkillPerks = new()
            {
                { Skill.LightArmor, Ordinator.Perk.ORD_Lia00_LightArmorMastery_Perk_00 },
                { Skill.HeavyArmor, Ordinator.Perk.ORD_Hea00_HeavyArmorMastery_Perk_00 }
            },
            MagickaSkillPerks = new()
            {
                { Skill.Alteration, Ordinator.Perk.ORD_Alt00_AlterationMastery_Perk_00 },
                { Skill.Conjuration, Ordinator.Perk.ORD_Con00_ConjurationMastery_Perk_00 },
                { Skill.Destruction, Ordinator.Perk.ORD_Des00_DestructionMastery_Perk_00 },
                { Skill.Illusion, Ordinator.Perk.ORD_Ill00_IllusionMastery_Perk_00 },
                { Skill.Restoration, Ordinator.Perk.ORD_Res00_RestorationMastery_Perk_00 },
            },
            SpeedSkillPerks = new()
            {
                { Skill.LightArmor, Ordinator.Perk.ORD_Lia00_LightArmorMastery_Perk_00 },
                { Skill.HeavyArmor, Ordinator.Perk.ORD_Hea00_HeavyArmorMastery_Perk_00 }
            },
            AttackSpeedSkillPerks = new()
            {
                { Skill.OneHanded, Ordinator.Perk.ORD_One00_OneHandedMastery_Perk_00 },
                { Skill.TwoHanded, Ordinator.Perk.ORD_Two00_TwoHandedMastery_Perk_00 },
            },
            RangedAttackSkillPerks = new()
            {
                { Skill.Archery, Ordinator.Perk.ORD_Arc00_ArcheryMastery_Perk_00 }
            }
        };

    }
}