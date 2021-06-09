using Mutagen.Bethesda;
using Mutagen.Bethesda.FormKeys.SkyrimSE;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Synthesis;
using Newtonsoft.Json.Linq;
using Noggog;
using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using Mutagen.Bethesda.Plugins.Exceptions;

namespace ActionSpeedX
{


    public class ArmorPatcher
    {

        const string ATTACK_SPEED   = "AttackSpeed";
        const string MOVEMENT_SPEED = "MoveSpeed";
        const string POWER_ATTACK   = "PowerAttacks";
        const string SPELL_COST     = "SpellCosts";
        const string MAGICKA        = "MagickaRegen";
        const string STAMINA        = "StaminaRegen";
        const string RANGED_ATTACK  = "RangedAttack";

        const string LIGHT = "Light";
        //const string MEDIUM         = "Medium";
        const string HEAVY = "Heavy";

        const string GAUNTLETS = "Gauntlets";
        const string HELMET    = "Helmet";
        const string CUIRASS   = "Cuirass";
        const string BOOTS     = "Boots";
        const string SHIELD    = "Shield";

        const string ATTACK_SPELL  = "ASX_AttackSpell";
        const string MOVE_SPELL    = "ASX_MoveSpell";
        const string RANGED_SPELL  = "ASX_RangedSpell";
        const string MAGICKA_SPELL = "ASX_MagickaSpell";
        const string STAMINA_SPELL = "ASX_StaminaSpell";

        const string MATERIALS_FILE    = "armor_materials.json";
        const string DESCRIPTIONS_FILE = "armor_descriptions.json";


        private readonly IPatcherState<ISkyrimMod, ISkyrimModGetter> state;
        private readonly Settings settings; // in memory rep of settings.json
        private readonly Dictionary<string, bool> descriptionSettings; 
        private readonly JObject armorDescriptions; // in memory rep of armor_descriptions.json
        private readonly Dictionary<string, int> materialRanks; // In memory rep of armor_materials.json

        public ArmorPatcher(IPatcherState<ISkyrimMod, ISkyrimModGetter> state, ActionSpeedX.Settings settings)
        {
            this.state = state;
            this.settings = settings;
            // This is looped through when adding descriptions. See PatchArmorDescription for usage.
            this.descriptionSettings = new Dictionary<string, bool> {
                {ATTACK_SPEED, this.settings.AttackSpeed },
                {MOVEMENT_SPEED, this.settings.MoveSpeed},
                {MAGICKA, this.settings.MagickaRegen},
                {POWER_ATTACK, this.settings.PowerAttacks },
                {RANGED_ATTACK, this.settings.RangedAttack },
                {SPELL_COST, this.settings.SpellCosts },
                {STAMINA, this.settings.StaminaRegen }
            };

            this.materialRanks     = LoadMaterialsFromDisk();
            this.armorDescriptions = LoadDescriptionsFromDisk();
        }

        public void PatchArmors()
        {
            /**
             * 1. Loop over all armors.
             * 2. For each armor, iterate over its keywords and match it to the tier rank in armor_rankings.json. Grab the HIGHEST tier.
             * 3. Based on that tier + armor slot + armor type, assign it a keyword from the appropiate ASX_<armor> keyword from Light/HeavyArmorKeywordCollection
             * 4. Based on tier, slot, armortype, attach the armor script and modify its properties to add the appropriate spells(by form id)
             * 5. If description setting is turned on, update the item description.
             */


            ScriptEntry templateArmorScript, templateShieldScript;
            if (!FormKeys.Armor.ASX_ArmorTemplate.TryResolve(this.state.LinkCache, out var templateArmor) || !FormKeys.Armor.ASX_ShieldTemplate.TryResolve(this.state.LinkCache, out var templateShield))
            {
                throw new Exception("Could not resolve armor templates");
            }
            if (templateArmor.VirtualMachineAdapter == null || templateArmor.VirtualMachineAdapter.Scripts == null || templateShield.VirtualMachineAdapter == null || templateShield.VirtualMachineAdapter.Scripts == null)
            {
                throw new Exception("Could not resolve armor template scripts");
            }
            templateArmorScript  = templateArmor.VirtualMachineAdapter.Scripts[0].DeepCopy();
            templateShieldScript = templateShield.VirtualMachineAdapter.Scripts[0].DeepCopy();


            foreach (var armor in this.state.LoadOrder.PriorityOrder.WinningOverrides<IArmorGetter>())
            {
                try
                {

                    if (armor.EditorID == null || armor.Keywords == null || armor.BodyTemplate == null || armor.BodyTemplate.ArmorType == ArmorType.Clothing) continue;
                    if (this.settings.CuirassOnly && !armor.HasKeyword(Skyrim.Keyword.ArmorCuirass)) continue;

                    string armorType;
                    Dictionary<string, List<FormLink<IKeywordGetter>>> armorKeysMap;
                    ActionSpeedX.FormKeys.ArmorActionSpells spellsToAdd;
                    if (armor.BodyTemplate.ArmorType == ArmorType.LightArmor)
                    {
                        armorKeysMap = FormKeys.Keywords.LightArmorKeywordCollection;
                        armorType = LIGHT;

                    }
                    else
                    {
                        armorKeysMap = FormKeys.Keywords.HeavyArmorKeywordCollection;
                        armorType = HEAVY;
                    }

                    int tier = -1;
                    /* We want to grab the highest material tier as some items can have multiple material keywrods
                       Loop over the armorRankings(see armor_materials.json) and check the current armors keywords for a match.
                       Item.key = int/str, item.val=List(armor material strings)
                    */

                    foreach (var keyword in armor.Keywords)
                    {
                        if (keyword.TryResolve(state.LinkCache, out var kw))
                        {
                            if (kw.EditorID != null && this.materialRanks.ContainsKey(kw.EditorID))
                            {
                                int rank = this.materialRanks[kw.EditorID];
                                if (rank > tier) tier = rank;
                            }
                        }
                    }

                    if (tier < 0)
                    {
                        if (armor.EditorID.Contains("ArmorGuard"))
                        {
                            tier = 1;
                        }
                        else
                        {
                            Console.WriteLine($"No recognized material type for {armor.EditorID}. Skipping. File an issue if it must be included.");
                            continue;
                        }
                    }
                    else
                    {
                        tier--; //correct array access
                    }
                    string slot;

                    if (armor.HasKeyword(Skyrim.Keyword.ArmorBoots)) slot          = BOOTS;
                    else if (armor.HasKeyword(Skyrim.Keyword.ArmorCuirass)) slot   = CUIRASS; //unfortunately this is checked twice with cuirass only setting
                    else if (armor.HasKeyword(Skyrim.Keyword.ArmorGauntlets)) slot = GAUNTLETS;
                    else if (armor.HasKeyword(Skyrim.Keyword.ArmorHelmet)) slot    = HELMET;
                    else if (armor.HasKeyword(Skyrim.Keyword.ArmorShield)) slot    = SHIELD;
                    else
                    {
                        Console.WriteLine("No matching equip slot for " + armor.EditorID);
                        continue;
                    }
                    var nw = state.PatchMod.Armors.GetOrAddAsOverride(armor);
                    nw.Keywords?.Add(armorKeysMap[slot][tier]);

                    // Grab armor spells
                    if (armorType == LIGHT)
                    {
                        spellsToAdd = FormKeys.ActionSpeedXSpells.LightArmorActionSpellCollection[slot][tier]; // expect an error here?
                    }
                    else
                    {
                        spellsToAdd = FormKeys.ActionSpeedXSpells.HeavyArmorActionSpellCollection[slot][tier]; // expect an error here?
                    }

                    // Calc script to add

                    ScriptEntry scriptCopy = slot == SHIELD ? templateShieldScript.DeepCopy() : templateArmorScript.DeepCopy();
                    foreach (ScriptObjectProperty property in scriptCopy.Properties)
                    {
                        // TODD: use a map
                        if (property.Name == ATTACK_SPELL) property.Object.FormKey = spellsToAdd.AttackSpell.FormKey;
                        else if (property.Name == MOVE_SPELL) property.Object.FormKey = spellsToAdd.SpeedSpell.FormKey;
                        else if (property.Name == STAMINA_SPELL) property.Object.FormKey = spellsToAdd.StaminaSpell.FormKey;
                        else if (property.Name == MAGICKA_SPELL) property.Object.FormKey = spellsToAdd.MagickaSpell.FormKey;
                        else if (property.Name == RANGED_SPELL && spellsToAdd.RangedAttackSpell != null) property.Object.FormKey = spellsToAdd.RangedAttackSpell.FormKey;// useless check but we did set the field as nullable because of laziness
                    }

                    nw.VirtualMachineAdapter ??= new();
                    //if (nw.VirtualMachineAdapter == null) nw.VirtualMachineAdapter = new();
                    nw.VirtualMachineAdapter.Scripts.Add(scriptCopy);

                    if (this.settings.Descriptions) PatchArmorDescription(nw, armorType, slot, tier);
                    
                } catch (Exception e)
                {
                    throw RecordException.Create("Error processing armor record", armor, e);
                }
            }
        }

        
        private void PatchArmorDescription(Armor armor, string armorType, string armorSlot, int armorTier)
        {

            // Shields and Boots share the same description magnitudes. Shield is not defined in armor_descriptions.json
            if (armorSlot == SHIELD) armorSlot = BOOTS;

            //Helmets and Gauntlets share the same description magnitude. Gauntlet is not defined in armor_descriptions.json
            if (armorSlot == HELMET) armorSlot = GAUNTLETS;

            // add descriptions really ugly dont look
            string newDescription = "";
            foreach (var item in this.descriptionSettings)
            {
                if (item.Value)
                {
                    try
                    {
                        string description = "";
                        string magnitude   = "";
                        JToken? dex        = this.armorDescriptions.SelectToken($"Descriptions.{item.Key}");

                        if (dex != null)
                        {
                            description = dex.ToString();
                        }
                        
                        JToken? mag = this.armorDescriptions.SelectToken($"Magnitudes.{armorSlot}.{item.Key}.{armorType}[{armorTier}]");
                        
                        if (mag != null)
                        {
                            magnitude = mag.ToString();
                        }

                        newDescription += description.Replace("{", magnitude);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
            }
            if (armor.Description?.String.IsNullOrEmpty() ?? true)
            {
                armor.Description = newDescription;
            }
            else
            {
                if (armor.Description?.String?.EndsWith(".") ?? false)
                {
                    armor.Description = armor.Description?.String + " " + newDescription;
                }
                else
                {
                    armor.Description = armor.Description?.String + ". " + newDescription;
                }
            }
        }


        private Dictionary<string, int> LoadMaterialsFromDisk()
        {
            string file = Path.Combine(this.state.ExtraSettingsDataPath, MATERIALS_FILE); // already validated in callee
            var armorMaterials = JObject.Parse(File.ReadAllText(file));
            Dictionary<string, int>? materials = armorMaterials.ToObject<Dictionary<string, int>>();
            if (materials == null)
            {
                throw new Exception("Could not parse armor materials file");
            }
            return materials;
        }

        private JObject LoadDescriptionsFromDisk()
        {
            string file = Path.Combine(this.state.ExtraSettingsDataPath, DESCRIPTIONS_FILE); // already validated in callee
            return JObject.Parse(File.ReadAllText(file));
        }

    }
}