using System.Collections.Generic;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.FormKeys.SkyrimSE;
using Mutagen.Bethesda.Plugins;

namespace ActionSpeedX.Patchers
{
    public static class SpellStatics
    {

        const string ORD_WIND       = "Move 5% faster if wearing all Light Armor.";
        //const string VOKRI_WIND     = "Move 5% faster if wearing all Light Armor.";
        const string ADA_AGILITY    = "You gain 7.5% Stamina Regeneration when wearing three pieces of light armor.";
        const string ADA_AGILITY2   = "You gain 15% Stamina Regeneration when wearing three pieces of light armor.";
        const string ADA_ATHLETICS  = "You move 5% faster when wearing three pieces of light armor.";
        const string ADA_ATHLETICS2 = "You move 10% faster when wearing three pieces of light armor.";


        /// <summary>
        /// Contains a perks form id and a description to replace.
        /// </summary>
        public struct PerkDescriptionMapping
        {
            public FormLink<IPerkGetter> PerkForm;
            public string Description;

            public PerkDescriptionMapping(FormLink<IPerkGetter> formLink, string description)
            {
                this.PerkForm    = formLink;
                this.Description = description;
            }
        }

        /// <summary>
        ///  cContains PerkDescriptionMapping pertaining to stamina and speed related perks.
        /// </summary>
        public struct PerkDescriptionMappings
        {
            public readonly List<PerkDescriptionMapping> StaminaPerks;
            public readonly List<PerkDescriptionMapping> SpeedPerks;
            public PerkDescriptionMappings(List<PerkDescriptionMapping> staminaPerks, List<PerkDescriptionMapping> speedPerks)
            {
                this.StaminaPerks = staminaPerks;
                this.SpeedPerks  = speedPerks;
            }
        }

        // Description mappings for adamant
        public static readonly PerkDescriptionMappings AdamantPerkMappings = new(
            new List<PerkDescriptionMapping> {
                new PerkDescriptionMapping(Adamant.Perk.MAG_Agility30, ADA_AGILITY),
                new PerkDescriptionMapping(Adamant.Perk.MAG_Agility60, ADA_AGILITY2)
                },
            new List<PerkDescriptionMapping> {
                new PerkDescriptionMapping(Adamant.Perk.MAG_Athletics40, ADA_ATHLETICS),
                new PerkDescriptionMapping(Adamant.Perk.MAG_Athletics60, ADA_ATHLETICS2)
                }
            );

        // Description mappings for adamant
        public static readonly PerkDescriptionMappings EnaiPerkMappings = new(
            new List<PerkDescriptionMapping> { // clean up these empty lists during enchantment pr.
                },
            new List<PerkDescriptionMapping> {
                new PerkDescriptionMapping(Skyrim.Perk.WindWalker, ORD_WIND),
                }
            );

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
            Agility: Agility gives 50/100% stamina renegeration at level 40/60 with light armor. ASX nerfs stamina regen by 15/20% assuming your skill matches the armor tier. We nerf to 7.5%/15
            Athletics: Athletics Give 10/20% speed boost. The max light armor speed reduction from ASX is 10% when on level. We nerf it to give 5/10%. Yes it is unbalanced but thats the design.
            */
        public static readonly SpellFormEffectsMagnitudeMappings AdamantSpellEffectMappings = new(
            new List<SpellFormEffectsMagnitudeMapping> {
                new SpellFormEffectsMagnitudeMapping(Adamant.Spell.MAG_PerkAgility30, 0, 7.5f, "MAG_PerkAgility30"),
                new SpellFormEffectsMagnitudeMapping(Adamant.Spell.MAG_PerkAgility60, 0, 15.0f, "MAG_PerkAgility60")
            },
            new List<SpellFormEffectsMagnitudeMapping> {
                new SpellFormEffectsMagnitudeMapping(Adamant.Spell.MAG_abAthletics40, 0, 5.0f, "MAG_abAthletics40"),
                new SpellFormEffectsMagnitudeMapping(Adamant.Spell.MAG_abAthletics60, 0, 10.0f, "MAG_abAthletics60")
            }
        );

        public static readonly SpellFormEffectsMagnitudeMappings OrdinatorSpellEffectMappings = new(
            new List<SpellFormEffectsMagnitudeMapping> {
            },
            new List<SpellFormEffectsMagnitudeMapping> {
                new SpellFormEffectsMagnitudeMapping(Ordinator.Spell.ORD_Lia_Windrunner_Spell_Ab, 0, 5.0f, "ORD_Lia_Windrunner_Spell_Ab")
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