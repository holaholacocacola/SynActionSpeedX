using Mutagen.Bethesda;
using System.Collections.Generic;
using Mutagen.Bethesda.FormKeys.SkyrimSE;

namespace ActionSpeedX
{
    public static partial class FormKeys
    {
        // This contains spells(abilities) for perk mods that we need to rebalance. If one of these mods update, update the form id here
       


        // This contains spells(abilities) for adamant that we need to rebalance. If one of these mods update, update the form id here
        public static class AdamantSpells
        {

            /**
                Patch  Agility perk. Agility gives 50/100% stamina renegeration at level 40/60 with light armor. ASX
                imposes a 15/20% nerf to stamina regeneration at those levels so it needs to be rebalanced
            */

            /**
            * Patch Athletics perks. Athletics Give 10/20% speed boost. The max light armor reduction is 10% when on level so this is too much. We nerf it to give 1/2% total speed which is ~equal to offsetting gauntlets
            * We also patch pilgram of akatosh from 10%->3% which is enough to offset boots in most cases
            */
            private static ModKey ModKey = ModKey.FromNameAndExtension("Adamant.esp");
            
            private static FormKey MAG_PerkAgility30    => Skyrim.ASpell.PerkWindWalkerStamina; // This will be reduced from 50% -> 5%. Affects stamina regeneration. Why magus why...
            private static FormKey MAG_PerkAgility60    => ModKey.MakeFormKey(0x0F38DA); // This will be reduced from 100% -> 5%. Affects stamina regeneration
            private static FormKey MAG_abAthletics40    => ModKey.MakeFormKey(0x0F38D7); // This will be reduced from 10 -> 1%. Affects movement speed
            private static FormKey MAG_abAthletics60    => ModKey.MakeFormKey(0x153BF7); // This will be reduced from 10-> 2%. Affects movement speed.
            private static FormKey MAG_abPilgrimAkatosh => ModKey.MakeFormKey(0x098653); // This will be reduced from 10-> 3%. Affects movement speed.

            public static List<SpellModifier> StaminaSpells = new List<SpellModifier> { 
                new SpellModifier(MAG_PerkAgility30, 0, 5.0f, "MAG_PerkAgility30"),
                new SpellModifier(MAG_PerkAgility60, 0, 5.0f, "MAG_PerkAgility60")
            };
            public static List<SpellModifier> MoveSpells = new List<SpellModifier> { 
                new SpellModifier(MAG_abAthletics40, 0, 1.0f, "MAG_abAthletics40"),
                new SpellModifier(MAG_abAthletics60, 0, 2.0f, "MAG_abAthletics60"),
                new SpellModifier(MAG_abPilgrimAkatosh, 0, 3.0f, "MAG_abPilgrimAkatosh")                                                                      
            };
            
        }

        public static class OrdinatorSpells
        {
            private static ModKey ModKey = ModKey.FromNameAndExtension("Ordinator - Perks Of Skyrim.esp");

            private static FormKey ORD_Spe_Windborne_Spell_ProcSelf => ModKey.MakeFormKey(0x022D8E); // 15% -> 2% MOvespeed when stacking shouts
            private static FormKey ORD_Lia_Windrunner_Spell_Ab      => ModKey.MakeFormKey(0x009B8D); // -> 1% movespeed for light armor skill 40
            private static FormKey ORD_Lia_FightOrFlight_Spell_Ab   => ModKey.MakeFormKey(0x17C1DC); // Stamina regen. 10% -> 3% ??

            public static List<SpellModifier> StaminaSpells = new List<SpellModifier> {
                new SpellModifier(ORD_Lia_FightOrFlight_Spell_Ab, 1, 3.0f, "ORD_Lia_FightOrFlight_Spell_Ab"),

            };

            public static List<SpellModifier> MoveSpells = new List<SpellModifier> {
                new SpellModifier(ORD_Lia_Windrunner_Spell_Ab, 0, 1.0f, "ORD_Lia_Windrunner_Spell_Ab"),
                new SpellModifier(ORD_Spe_Windborne_Spell_ProcSelf, 0, 2.0f, "ORD_Spe_Windborne_Spell_ProcSelf"),
            };
        }

        public static class VokriiSpells
        {

            private static ModKey ModKey = ModKey.FromNameAndExtension("Vokrii - Minimalistic Perks of Skyrim.esp");

            private static FormKey VKR_Alc_Adrenaline_Spell_Ab => ModKey.MakeFormKey(0x321427); // Reduce speed buff from 10% -> 4% when using beneficial potions
            private static FormKey VKR_Lia_Wardancer_Spell_Ab  => ModKey.MakeFormKey(0x335873); // Reduce move speed buff from 10% -> 1%
            private static FormKey VKR_Lia_Windrunner_Spell_Ab => ModKey.MakeFormKey(0x009B89); // Reduce move speed buff from 10% -> 1%

            public static List<SpellModifier> StaminaSpells = new List<SpellModifier> {};
            public static List<SpellModifier> MoveSpells = new List<SpellModifier> {
                new SpellModifier(VKR_Alc_Adrenaline_Spell_Ab, 0, 4.0f, "VKR_Alc_Adrenaline_Spell_Ab"),
                new SpellModifier(VKR_Lia_Wardancer_Spell_Ab, 2, 1.0f, "VKR_Lia_Wardancer_Spell_Ab"),
                new SpellModifier(VKR_Lia_Windrunner_Spell_Ab, 0, 1.0f, "VKR_Lia_Winrunner_Spell_Ab"),

            };

        }

        //contains form id, slot, new magnitude
        public class SpellModifier
        {
            public FormKey formKey; // id
            public int effectSlot; // index to modify in effects array
            public float magnitude; // value to set
            public string editorId;
            public SpellModifier(FormKey formkey, int effectSlot, float magnitude, string id)
            {
                this.formKey = formkey;
                this.effectSlot = effectSlot;
                this.magnitude = magnitude;
                this.editorId = id;
            }

        }

    }
}