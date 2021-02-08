using System;
using System.IO;
using System.Linq;
using Mutagen.Bethesda;
using Mutagen.Bethesda.Synthesis;
using Mutagen.Bethesda.Skyrim;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ActionSpeedX
{
    public class Program
    {

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

            ActionSpeedX.Settings patchSettings = JsonConvert.DeserializeObject<ActionSpeedX.Settings>(File.ReadAllText(requiredFiles[3]));// This could fail if user messes with settings but w/e

            // PerkMod Patcher. Modifies magnitudes.
            if (patchSettings.BalancePerkMods)
            {
                ActionSpeedX.SpellPatcher spellPatcher = new SpellPatcher(state, patchSettings);
                if(!spellPatcher.PatchSpells()) throw new Exception("Error encountered while balancing perks. Check logs.");
            }

            // Armor Patcher. Adds keywords
            Console.WriteLine("Patching armors");
            ActionSpeedX.ArmorPatcher armorPatcher = new ArmorPatcher(state, patchSettings);
            armorPatcher.PatchArmors();

            // Npc patcher. AddsPerks
            Console.WriteLine("Patching npcs");
            ActionSpeedX.NpcPatcher npcPatcher = new NpcPatcher(state, patchSettings);
            npcPatcher.PatchNpcs();

        }
    }
}
