using System.Collections.Generic;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.FormKeys.SkyrimSE;
using Mutagen.Bethesda.Plugins;

namespace ActionSpeedX.Patchers
{
    public static class SpellStatics
    {
        /// <summary>
        /// This contains a spell records form id, editorid, effect index, and magnitude.
        ///
        /// </summary>
        public struct SpellFormEffectsMagnitudeMapping
        {
            public FormLink<ISpellGetter> SpellForm; // id
            public int EffectSlot; // index to modify in effects array
            public float Magnitude; // value to set
            public string EditorId; // Editor ID in case record throws an error.
            public SpellFormEffectsMagnitudeMapping(FormLink<ISpellGetter> formLink, int effectSlot, float magnitude, string id)
            {
                this.SpellForm = formLink;
                this.EffectSlot = effectSlot;
                this.Magnitude = magnitude;
                this.EditorId = id;
            }
        }

        public struct SpellFormEffectsMagnitudeMappings
        {
            public readonly List<SpellFormEffectsMagnitudeMapping> StaminaSpells;
            public readonly List<SpellFormEffectsMagnitudeMapping> SpeedSpells;
            public SpellFormEffectsMagnitudeMappings(List<SpellFormEffectsMagnitudeMapping> staminaSpells, List<SpellFormEffectsMagnitudeMapping> speedSpells)
            {
                this.StaminaSpells = staminaSpells;
                this.SpeedSpells = speedSpells;
            }
        }

        /**
            Agility: Agility gives 50/100% stamina renegeration at level 40/60 with light armor. ASX nerfs stamina regen by 15/20% assuming your skill matches the armor tier. We nerf to 5%/10
            Athletics: Athletics Give 10/20% speed boost. The max light armor speed reduction from ASX is 10% when on level. We nerf it to give 1/2% total(3) speed which is ~equal to offsetting gauntlets
            */
        public static readonly SpellFormEffectsMagnitudeMappings AdamantSpellEffectMappings = new(
            new List<SpellFormEffectsMagnitudeMapping> {
                new SpellFormEffectsMagnitudeMapping(Adamant.Spell.MAG_PerkAgility30, 0, 5.0f, "MAG_PerkAgility30"),
                new SpellFormEffectsMagnitudeMapping(Adamant.Spell.MAG_PerkAgility60, 0, 10.0f, "MAG_PerkAgility60")
            },
            new List<SpellFormEffectsMagnitudeMapping> {
                new SpellFormEffectsMagnitudeMapping(Adamant.Spell.MAG_PerkAgility30, 0, 2.5f, "MAG_abAthletics40"),
                new SpellFormEffectsMagnitudeMapping(Adamant.Spell.MAG_PerkAgility60, 0, 5.0f, "MAG_abAthletics60")
            }
        );

        public static readonly SpellFormEffectsMagnitudeMappings OrdinatorSpellEffectMappings = new(
            new List<SpellFormEffectsMagnitudeMapping> {
                new SpellFormEffectsMagnitudeMapping(Ordinator.Spell.ORD_Lia_FightOrFlight_Spell_Ab, 1, 3.0f, "ORD_Lia_FightOrFlight_Spell_Ab")
            },
            new List<SpellFormEffectsMagnitudeMapping> {
                new SpellFormEffectsMagnitudeMapping(Ordinator.Spell.ORD_Lia_Windrunner_Spell_Ab, 0, 1.0f, "ORD_Lia_Windrunner_Spell_Ab")
            }
        );

        // Wind runner. 10% -5%
        public static readonly SpellFormEffectsMagnitudeMappings VokriiSpellEffectMappings = new(
           new List<SpellFormEffectsMagnitudeMapping> {
           },
           new List<SpellFormEffectsMagnitudeMapping> {
                new SpellFormEffectsMagnitudeMapping(Vokrii.Spell.VKR_Lia_Windrunner_Spell_Ab, 0, 5.0f, "VKR_Lia_Winrunner_Spell_Ab")
           }
       );
    }
}