using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Mutagen.Bethesda;
using Mutagen.Bethesda.Synthesis;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.FormKeys.SkyrimSE;
using Newtonsoft.Json.Linq;
using Noggog;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ActionSpeedX
{
    public class Program
    {

        static ModKey Adamant = ModKey.FromNameAndExtension("Adamant.esp");
        static ModKey Vokrii = ModKey.FromNameAndExtension("Vokrii - Minimalistic Perks of Skyrim.esp");
        static ModKey Ordinator = ModKey.FromNameAndExtension("Ordinator - Perks Of Skyrim.esp");

        public static async Task<int> Main(string[] args)
        {
            return await SynthesisPipeline.Instance
                .AddPatch<ISkyrimMod, ISkyrimModGetter>(RunPatch)
                .AddRunnabilityCheck(RunnabilityCheck)
                .Run(args, new RunPreferences()
                {
                    ActionsForEmptyArgs = new RunDefaultPatcher()
                    {
                        IdentifyingModKey = "action_speed_x_patch.esp",
                        TargetRelease = GameRelease.SkyrimSE,
                    }
                });
        }

        public static async Task RunnabilityCheck(IRunnabilityState state)
        {
            state.LoadOrder.AssertHasMod(ModKey.FromNameAndExtension("ActionSpeedX.esp"));
        }

        private static List<FormKey> LoadPerks(ActionSpeedX.Settings patchSettings)
        {
            //set up perks to add. This should be done in Settings but w/e
            List<FormKey> perksToAdd = new List<FormKey>();
            if (patchSettings.AttackSpeed) perksToAdd.AddRange(ActionSpeedX.FormKeys.Perks.AttackSpeed);

            if (patchSettings.MagickaRegen) perksToAdd.AddRange(ActionSpeedX.FormKeys.Perks.MagickaRegen);

            if (patchSettings.MoveSpeed) perksToAdd.AddRange(ActionSpeedX.FormKeys.Perks.MoveSpeed);

            if (patchSettings.RangedAttack) perksToAdd.AddRange(ActionSpeedX.FormKeys.Perks.RangedSpeed);

            if (patchSettings.PowerAttacks) perksToAdd.AddRange(ActionSpeedX.FormKeys.Perks.PowerAttacks);

            if (patchSettings.StaminaRegen) perksToAdd.AddRange(ActionSpeedX.FormKeys.Perks.StaminaRegen);

            if (patchSettings.SpellCosts) perksToAdd.AddRange(ActionSpeedX.FormKeys.Perks.SpellCosts);

            return perksToAdd;
        }

        public static void RunPatch(IPatcherState<ISkyrimMod, ISkyrimModGetter> state)
        {
            
            /*
             *  Load all settings files. See Readme for explanation of how they are consumed
             */
            string[] requiredFiles = { state.ExtraSettingsDataPath + @"\armor_descriptions.json", 
                                       state.ExtraSettingsDataPath + @"\armor_materials.json",
                                       state.ExtraSettingsDataPath + @"\races.json",
                                       state.ExtraSettingsDataPath + @"\settings.json"};

            string[] foundFiles = Directory.GetFiles(state.ExtraSettingsDataPath);
            if (!requiredFiles.SequenceEqual(foundFiles))
                throw new Exception("Missing one of the following json files in the Data folder: armor_descriptions, armor_materials, races");

            var availableRaces = JObject.Parse(File.ReadAllText(requiredFiles[2]));
            ActionSpeedX.Settings patchSettings = JsonConvert.DeserializeObject<ActionSpeedX.Settings>(File.ReadAllText(requiredFiles[3]));// This could fail if user messes with settings but w/e

            /**
             *  Load the races we want to use
             * */
            List<JToken> races;
            JToken? defaultRaces = availableRaces.SelectToken("default");
            if (defaultRaces == null) throw new Exception("Error reading races file");

            races = defaultRaces.ToList();
            if (patchSettings.Creatures)
            {
                JToken? creatures = availableRaces.SelectToken("creatures");
                if (creatures != null) races.AddRange(creatures.ToList());
            }

            // see PatchNpc for usage
            List<FormKey> perkstoAdd = LoadPerks(patchSettings);
            if (perkstoAdd.Count() == 0)
            {
                throw new Exception("No settings enabled");
            }

            // Armor Patcher. Adds keywords
            Console.WriteLine("Patching armors");
            ActionSpeedX.ArmorPatcher armorPatcher = new ArmorPatcher(state, patchSettings);
            armorPatcher.PatchArmors();

            // Npc patcher. AddsPerks
            Console.WriteLine("Patching npcs");
            ActionSpeedX.NpcPatcher npcPatcher = new NpcPatcher(state, patchSettings);
            npcPatcher.PatchNpcs();


            // PerkMod Patcher. Modifies magnitudes.
            if (!patchSettings.BalancePerkMods) return;

            // CHeck for adamant
            if (state.LoadOrder.ContainsKey(Adamant))
            {
                Console.WriteLine("Adamant will be patched.");
                bool success = RebalancePerks(state, patchSettings, ActionSpeedX.FormKeys.AdamantSpells.StaminaSpells, ActionSpeedX.FormKeys.AdamantSpells.MoveSpells);
                if (!success) Console.WriteLine("Failed to patch adamant");
            }

            // Check for ordinator
            if (state.LoadOrder.ContainsKey(Ordinator))
            {
                Console.WriteLine("Ordinator will be patched.");
                bool success = RebalancePerks(state, patchSettings, ActionSpeedX.FormKeys.OrdinatorSpells.StaminaSpells, ActionSpeedX.FormKeys.OrdinatorSpells.MoveSpells);
                if (!success) Console.WriteLine("Failed to patch ordinator");
            }

            // CHeck for vokrii
            if (state.LoadOrder.ContainsKey(Vokrii))
            {
                Console.WriteLine("Vokrii will be patched.");
                bool success = RebalancePerks(state, patchSettings, ActionSpeedX.FormKeys.VokriiSpells.StaminaSpells, ActionSpeedX.FormKeys.VokriiSpells.MoveSpells);
                if (!success) Console.WriteLine("Failed to patch vokrii");
            }
        }

       
        private static bool RebalancePerks(IPatcherState<ISkyrimMod, ISkyrimModGetter> state, ActionSpeedX.Settings patchSettings, List<FormKeys.SpellEffectModifier> staminaSpells, List<FormKeys.SpellEffectModifier> speedSpells)
        {

            bool hasError = false;
            if (patchSettings.StaminaRegen)
            {
                foreach (var stamModifier in staminaSpells)
                {
                    if (!ModifySpell(state, stamModifier)) hasError = true;
                }
            }

            if (patchSettings.MoveSpeed)
            {
                foreach (var speedModifier in speedSpells)
                {
                    if (!ModifySpell(state, speedModifier)) hasError = true;
                }
            }

            return !hasError;
        }

        private static bool ModifySpell(IPatcherState<ISkyrimMod, ISkyrimModGetter> state, ActionSpeedX.FormKeys.SpellEffectModifier spellToModify)
        {
            if (!state.LinkCache.TryResolve<ISpellGetter>(spellToModify.formKey, out var spell))
            {
                Console.Out.WriteLine($"Could not resolve form key for: {spellToModify.editorId}");
                return false;
            }
            var modifiedSpell = spell.DeepCopy();

            var effect = modifiedSpell.Effects[spellToModify.effectSlot];
            if (effect.Data == null)
            {
                Console.Out.WriteLine($"{spellToModify.editorId} has no effects.");
                return false;
            }
            
            effect.Data.Magnitude = spellToModify.magnitude;
            state.PatchMod.Spells.Add(modifiedSpell);
            return true;
        }

    }
}
