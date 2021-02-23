using Mutagen.Bethesda;
using System.Collections.Generic;
using Mutagen.Bethesda.FormKeys.SkyrimSE;

namespace ActionSpeedX
{
    public static partial class FormKeys
    {
        /// <summary>
        /// This class contains abilities from adamant that touch staminaratemult, and movementspeed. It contains instructions on how to rebalance those abilities.
        /// It covers the following perks: Agility, Athletics, and also handles the Pilgrim of Akatash buff
        /// </summary>
        public static class AdamantSpells
        {
            /**
            Agility: Agility gives 50/100% stamina renegeration at level 40/60 with light armor. ASX nerfs stamina regen by 15/20% assuming your skill matches the armor tier. We nerf to 5%
            Athletics: Athletics Give 10/20% speed boost. The max light armor speed reduction from ASX is 10% when on level. We nerf it to give 1/2% total(3) speed which is ~equal to offsetting gauntlets
            Akatash: Akatosh gices a 10% speed boost. This is reduced to 3% (Enough to offset boots)
            */

            private static ModKey ModKey                = ModKey.FromNameAndExtension("Adamant.esp");         
            private static FormKey MAG_PerkAgility30    => Skyrim.ASpell.PerkWindWalkerStamina; // This will be reduced from 50% -> 5%. Affects stamina regeneration. Why magus why...
            private static FormKey MAG_PerkAgility60    => ModKey.MakeFormKey(0x0F38DA); // This will be reduced from 100% -> 5%. Affects stamina regeneration
            private static FormKey MAG_abAthletics40    => ModKey.MakeFormKey(0x0F38D7); // This will be reduced from 10 -> 1%. Affects movement speed
            private static FormKey MAG_abAthletics60    => ModKey.MakeFormKey(0x153BF7); // This will be reduced from 10-> 2%. Affects movement speed.
            private static FormKey MAG_abPilgrimAkatosh => ModKey.MakeFormKey(0x098653); // This will be reduced from 10-> 3%. Affects movement speed.

            public static List<SpellEffectModifier> StaminaSpells = new List<SpellEffectModifier> { 
                new SpellEffectModifier(MAG_PerkAgility30, 0, 5.0f, "MAG_PerkAgility30"),
                new SpellEffectModifier(MAG_PerkAgility60, 0, 5.0f, "MAG_PerkAgility60")
            };
            public static List<SpellEffectModifier> MoveSpells = new List<SpellEffectModifier> { 
                new SpellEffectModifier(MAG_abAthletics40, 0, 1.0f, "MAG_abAthletics40"),
                new SpellEffectModifier(MAG_abAthletics60, 0, 2.0f, "MAG_abAthletics60"),
                new SpellEffectModifier(MAG_abPilgrimAkatosh, 0, 3.0f, "MAG_abPilgrimAkatosh")                                                                      
            };
        }

        /// <summary>
        /// This class contains abilities from ordinator that touch staminaratemult, and movementspeed. It contains instructions on how to rebalance those abilities.
        /// It covers the following perks: Windborne, Windrunner, Fight or Flight
        /// </summary>
        public static class OrdinatorSpells
        {
            private static ModKey ModKey = ModKey.FromNameAndExtension("Ordinator - Perks Of Skyrim.esp");

            private static FormKey ORD_Spe_Windborne_Spell_ProcSelf => ModKey.MakeFormKey(0x022D8E); // 15% -> 2% MOvespeed when stacking shouts
            private static FormKey ORD_Lia_Windrunner_Spell_Ab      => ModKey.MakeFormKey(0x009B8D); // -> 1% movespeed for light armor skill 40
            private static FormKey ORD_Lia_FightOrFlight_Spell_Ab   => ModKey.MakeFormKey(0x17C1DC); // Stamina regen. 10% -> 3% ??

            public static List<SpellEffectModifier> StaminaSpells = new List<SpellEffectModifier> {
                new SpellEffectModifier(ORD_Lia_FightOrFlight_Spell_Ab, 1, 3.0f, "ORD_Lia_FightOrFlight_Spell_Ab"),

            };

            public static List<SpellEffectModifier> MoveSpells = new List<SpellEffectModifier> {
                new SpellEffectModifier(ORD_Lia_Windrunner_Spell_Ab, 0, 1.0f, "ORD_Lia_Windrunner_Spell_Ab"),
                new SpellEffectModifier(ORD_Spe_Windborne_Spell_ProcSelf, 0, 2.0f, "ORD_Spe_Windborne_Spell_ProcSelf"),
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

            private static FormKey VKR_Alc_Adrenaline_Spell_Ab => ModKey.MakeFormKey(0x321427); // Reduce speed buff from 10% -> 4% when using beneficial potions
            private static FormKey VKR_Lia_Wardancer_Spell_Ab  => ModKey.MakeFormKey(0x335873); // Reduce move speed buff from 10% -> 1%
            private static FormKey VKR_Lia_Windrunner_Spell_Ab => ModKey.MakeFormKey(0x009B89); // Reduce move speed buff from 10% -> 1%

            public static List<SpellEffectModifier> StaminaSpells = new List<SpellEffectModifier> {};
            public static List<SpellEffectModifier> MoveSpells    = new List<SpellEffectModifier> {
                new SpellEffectModifier(VKR_Alc_Adrenaline_Spell_Ab, 0, 4.0f, "VKR_Alc_Adrenaline_Spell_Ab"),
                new SpellEffectModifier(VKR_Lia_Wardancer_Spell_Ab, 2, 1.0f, "VKR_Lia_Wardancer_Spell_Ab"),
                new SpellEffectModifier(VKR_Lia_Windrunner_Spell_Ab, 0, 1.0f, "VKR_Lia_Winrunner_Spell_Ab"),

            };
        }

        /// <summary>
        /// This contains a spell records form id, editorid, effect index, and magnitude.
        ///
        /// </summary>
        public class SpellEffectModifier
        {
            public FormKey formKey; // id
            public int effectSlot; // index to modify in effects array
            public float magnitude; // value to set
            public string editorId; // Editor ID in case record throws an error.
            public SpellEffectModifier(FormKey formkey, int effectSlot, float magnitude, string id)
            {
                this.formKey = formkey;
                this.effectSlot = effectSlot;
                this.magnitude = magnitude;
                this.editorId = id;
            }
        }
    }
}