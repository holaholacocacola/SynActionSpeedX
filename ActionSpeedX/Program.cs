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
        const string ATTACK_SPEED   = "AttackSpeed";
        const string MOVEMENT_SPEED = "MoveSpeed";
        const string POWER_ATTACK   = "PowerAttacks";
        const string SPELL_COST     = "SpellCosts";
        const string MAGICKA        = "MagickaRegen";
        const string STAMINA        = "StaminaRegen";
        const string RANGED_ATTACK  = "RangedAttack"; 
        
        const string LIGHT          = "Light";
        //const string MEDIUM         = "Medium";
        const string HEAVY          = "Heavy";

        const string GAUNTLETS      = "Gauntlets";
        const string HELMET         = "Helmet";
        const string CUIRASS        = "Cuirass";
        const string BOOTS          = "Boots";
        const string SHIELD         = "Shield";


        static ModKey Adamant = ModKey.FromNameAndExtension("Adamant.esp");
        static ModKey Vokrii = ModKey.FromNameAndExtension("Vokrii - Minimalistic Perks of Skyrim.esp");
        static ModKey Ordinator = ModKey.FromNameAndExtension("Ordinator - Perks Of Skyrim.esp");

        public static async Task<int> Main(string[] args)
        {
            return await SynthesisPipeline.Instance
                .AddPatch<ISkyrimMod, ISkyrimModGetter>(RunPatch)
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

            var armorDescriptions = JObject.Parse(File.ReadAllText(requiredFiles[0]));
            var armorMaterials = JObject.Parse(File.ReadAllText(requiredFiles[1]));
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

            //see PatchArmor for usage.
            Dictionary<String, List<JToken>> materialRanks = new Dictionary<string, List<JToken>>();
            foreach (var item in armorMaterials)
            {
                materialRanks[item.Key] = item.Value.ToList();
            }

            // This is looped through when adding descriptions. See PatchArmor for usage.
            Dictionary<String, bool> descriptionSettings = new Dictionary<string, bool> {
                {ATTACK_SPEED, patchSettings.AttackSpeed },
                {MOVEMENT_SPEED, patchSettings.MoveSpeed},
                {MAGICKA, patchSettings.MagickaRegen},
                {POWER_ATTACK, patchSettings.PowerAttacks },
                {RANGED_ATTACK, patchSettings.RangedAttack },
                {SPELL_COST, patchSettings.SpellCosts },
                {STAMINA, patchSettings.StaminaRegen }
            };

            // see PatchNpc for usage
            List<FormKey> perkstoAdd = LoadPerks(patchSettings);
            if (perkstoAdd.Count() == 0)
            {
                throw new Exception("No settings enabled");
            }

             // Armor Patcher. Adds keywords
            foreach (var armor in state.LoadOrder.PriorityOrder.WinningOverrides<IArmorGetter>())
            {
                if (armor.EditorID == null || armor.Keywords == null) continue;
                if (PatchArmor(state, armor, materialRanks, armorDescriptions, patchSettings.Descriptions, descriptionSettings)) System.Console.WriteLine($"Successfully patched  + {armor.EditorID}");
            }

            // Npc patcher. AddsPerks

            foreach (var npc in state.LoadOrder.PriorityOrder.WinningOverrides<INpcGetter>())
            {
                if (npc.Configuration.TemplateFlags.HasFlag(NpcConfiguration.TemplateFlag.SpellList)) continue; // Perks are inherited from a template
                if (npc.EditorID == null) continue;
                if (npc.Keywords != null && npc.Keywords.Contains(Skyrim.Keyword.ActorTypeGhost)) continue; // Ghost shouldnt be affected by armor
                if (!npc.Race.TryResolve(state.LinkCache, out var race) || race.EditorID == null || !races.Contains(race.EditorID)) continue; 
                
                if (PatchNpc(state, npc, perkstoAdd, patchSettings.Racials, patchSettings.Factions)) System.Console.WriteLine($"Successfully patched  + {npc.EditorID}");
            }

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

        private static bool PatchArmor(IPatcherState<ISkyrimMod, ISkyrimModGetter> state, IArmorGetter armor, Dictionary<String, List<JToken>> materialRanks , JObject armorDescriptions, bool patchDescriptions, Dictionary<String, bool> descriptionSettings)
        {

            string armorType; 
            Dictionary<string, List<FormKey>> armorKeysMap ;
            if (armor.BodyTemplate == null)
            {
                return false;
            }
            if (armor.BodyTemplate.ArmorType == ArmorType.LightArmor)
            {
                armorKeysMap = ActionSpeedX.FormKeys.Keywords.LightArmorKeywordCollection;
                armorType = LIGHT;
            }
            else if (armor.BodyTemplate.ArmorType ==  ArmorType.HeavyArmor)
            {
                armorKeysMap = ActionSpeedX.FormKeys.Keywords.HeavyArmorKeywordCollection;
                armorType = HEAVY;
            }
            else
            {
                return false;
            }

            int tier = -1;
            if (armor.Keywords == null) return false;// This is checked before this func is called but compiler complains if we dont check it again :|

            /* We want to grab the highest material tier as some items can have multiple material keywrods
               Loop over the armorRankings(see armor_materials.json) and check the current armors keywords for a match.
               Item.key = int/str, item.val=List(armor material strings)
            */
            foreach (var item in materialRanks)  //Garbage running time
            {
                foreach (var keyword in armor.Keywords)
                {
                    if (keyword.TryResolve(state.LinkCache, out var kw))
                    {
                        //Console.WriteLine(item.Key);
                        if (kw.EditorID != null && item.Value.Contains(kw.EditorID))
                        {
                            tier = Int32.Parse(item.Key) - 1; // This is always guaranteed to be a string. Dont flame me bic boi.
                            break;
                        }
                    }      
                }
            }

            if (tier < 0)
            {
                Console.WriteLine($"No recognized material type for {armor.EditorID}. Defaulting to tier 2 " );
                tier = 1;
            }

            string slot;

            if (armor.Keywords.Contains(Skyrim.Keyword.ArmorBoots)) slot = BOOTS;
            else if (armor.Keywords.Contains(Skyrim.Keyword.ArmorCuirass)) slot = CUIRASS;
            else if (armor.Keywords.Contains(Skyrim.Keyword.ArmorGauntlets)) slot = GAUNTLETS;
            else if (armor.Keywords.Contains(Skyrim.Keyword.ArmorHelmet)) slot = HELMET;
            else if (armor.Keywords.Contains(Skyrim.Keyword.ArmorShield)) slot = SHIELD;
            else
            {
               Console.WriteLine("No matching equip slot for " + armor.EditorID);
                return false;
            }
            var nw = state.PatchMod.Armors.GetOrAddAsOverride(armor);
            nw.Keywords?.Add(armorKeysMap[slot][tier]);

            if (!patchDescriptions) return true;

            // Shields and Boots share the same description magnitudes. Shield is not defined in armor_descriptions.json
            if (slot == SHIELD) slot = BOOTS;

            //Helmets and Gauntlets share the same description magnitude. Gauntlet is not defined in armor_descriptions.json
            if (slot == HELMET) slot = GAUNTLETS;
           
            // add descriptions really ugly dont look
            string newDescription = "";
            foreach(var item in descriptionSettings)
            {
                if (item.Value)
                {
                    try
                    {
                        string description = "";
                        string magnitude = "";
                        JToken? dex = armorDescriptions.SelectToken($"Descriptions.{item.Key}");
                        if (dex != null)
                        {
                            description = dex.ToString();
                        }
                        JToken? mag = armorDescriptions.SelectToken($"Magnitudes.{slot}.{item.Key}.{armorType}[{tier}]");
                        if (mag != null)
                        {
                            magnitude = mag.ToString();
                        }
                    
                        newDescription += description.Replace("{", magnitude);
                    } catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
            }
            if (nw.Description?.String.IsNullOrEmpty() ?? true)
            {
                nw.Description = newDescription;
            }
            else
            {
                if (nw.Description?.String?.EndsWith(".") ?? false)
                {
                    nw.Description = nw.Description?.String + " " + newDescription;
                }
                else
                {
                    nw.Description = nw.Description?.String + ". " + newDescription;
                }
            }

            return true;
        }

        private static bool PatchNpc(IPatcherState<ISkyrimMod, ISkyrimModGetter> state, INpcGetter npc, List<FormKey> perksToAdd, bool addRacial, bool addFactions)
        {

            var npcCopy = state.PatchMod.Npcs.GetOrAddAsOverride(npc);
            if (npcCopy.Perks == null) npcCopy.Perks = new ExtendedList<PerkPlacement>();
            foreach (var perk in perksToAdd)
            {
                PerkPlacement p = new PerkPlacement { Rank = 1, Perk = perk};
                npcCopy.Perks.Add(p);
            }

            if (npc.EditorID == "Player") // will c# cache this????
            {
               if(addRacial)
                {
                    // a quest runs after racemenu that will sift and apply the correct racial perk
                    PerkPlacement p = new PerkPlacement { Rank = 1, Perk = ActionSpeedX.FormKeys.Perks.ASX_DummyPerk};
                    npcCopy.Perks.Add(p);
                }
                return true;
            }

            if (addRacial)
            {
                if (npc.Race.TryResolve(state.LinkCache, out var race) && race.EditorID != null && ActionSpeedX.FormKeys.Perks.RacialPerks.ContainsKey(race.EditorID))
                {
                    PerkPlacement p = new PerkPlacement { Rank = 1, Perk = ActionSpeedX.FormKeys.Perks.RacialPerks[race.EditorID]};
                    npcCopy.Perks.Add(p);
                }
            }

            if (addFactions)
            {
                if (npc.Factions != null)
                {
                    foreach (var faction in npc.Factions)
                    {
                        if(faction.Faction.TryResolve(state.LinkCache, out var wtf) && wtf.EditorID != null && ActionSpeedX.FormKeys.Perks.FactionPerks.ContainsKey(wtf.EditorID))
                        {
                            PerkPlacement p = new PerkPlacement { Rank = 1, Perk = ActionSpeedX.FormKeys.Perks.FactionPerks[wtf.EditorID] };
                            npcCopy.Perks.Add(p);
                        }
                    }
                }
            }
            return true;
        }

        private static bool RebalancePerks(IPatcherState<ISkyrimMod, ISkyrimModGetter> state, ActionSpeedX.Settings patchSettings, List<FormKeys.SpellModifier> staminaSpells, List<FormKeys.SpellModifier> speedSpells)
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

        private static bool ModifySpell(IPatcherState<ISkyrimMod, ISkyrimModGetter> state, ActionSpeedX.FormKeys.SpellModifier spellToModify)
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
