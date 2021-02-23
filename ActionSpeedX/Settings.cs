using Mutagen.Bethesda;
using Mutagen.Bethesda.FormKeys.SkyrimSE;
using Mutagen.Bethesda.Skyrim;
using System.Collections.Generic;

namespace ActionSpeedX
{
    public class Settings
    {
        public bool Descriptions { get; set; } = true;
        public bool AttackSpeed { get; set; } = true;
        public bool MagickaRegen { get; set; } = true;
        public bool MoveSpeed { get; set; } = true;
        public bool PowerAttacks { get; set; } = true;
        public bool RangedAttack { get; set; } = true;
        public bool SpellCosts { get; set; } = true;
        public bool StaminaRegen { get; set; } = true;
        public bool Creatures { get; set; } = true;
        public bool Racials { get; set; } = true;
        public bool Factions { get; set; } = true;
        public bool BalancePerkMods { get; set; } = true;

        public HashSet<FormLink<IRaceGetter>> DefaultRaces = new HashSet<FormLink<IRaceGetter>>()
        {
            Skyrim.Race.ArgonianRace,
            Skyrim.Race.ArgonianRaceVampire,
            Skyrim.Race.BretonRace,
            Skyrim.Race.BretonRaceVampire,
            Skyrim.Race.DarkElfRace,
            Skyrim.Race.DarkElfRaceVampire,
            Skyrim.Race.DremoraRace,
            Skyrim.Race.ElderRace,
            Skyrim.Race.ElderRaceVampire,
            Skyrim.Race.HighElfRace,
            Skyrim.Race.HighElfRaceVampire,
            Skyrim.Race.ImperialRace,
            Skyrim.Race.ImperialRaceVampire,
            Skyrim.Race.KhajiitRace,
            Skyrim.Race.KhajiitRaceVampire,
            Skyrim.Race.NordRace,
            Skyrim.Race.NordRaceVampire,
            Skyrim.Race.OrcRace,
            Skyrim.Race.OrcRaceVampire,
            Skyrim.Race.RedguardRace,
            Skyrim.Race.RedguardRaceVampire,
            Skyrim.Race.WoodElfRace,
            Skyrim.Race.WoodElfRaceVampire,
        };
        public HashSet<FormLink<IRaceGetter>> CreatureRaces = new HashSet<FormLink<IRaceGetter>>()
        {
            Dawnguard.Race.DLC1BlackSkeletonRace,
            Dawnguard.Race.DLC1SoulCairnSkeletonArmorRace,
            Dawnguard.Race.DLC1SoulCairnSkeletonNecroRace,
            Dawnguard.Race.DLC1TrollFrostRaceArmored,
            Dawnguard.Race.DLC1TrollRaceArmored,
            Dragonborn.Race.DLC2HulkingDraugrRace,
            Skyrim.Race.DraugrRace,
            Dawnguard.Race.FalmerFrozenVampRace,
            Skyrim.Race.FalmerRace,
            Skyrim.Race.GiantRace,
            Skyrim.Race.RigidSkeletonRace,
            Dawnguard.Race.SkeletonArmorRace,
            Skyrim.Race.SkeletonRace,
            Skyrim.Race.DraugrMagicRace,
            Skyrim.Race.SkeletonNecroRace,
        };
    }
}