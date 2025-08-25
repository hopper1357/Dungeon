using System.Collections.Generic;

namespace Dungeon.Models
{
    public static class GameData
    {
        public static List<Industry> Industries { get; private set; }
        public static List<Workshop> Workshops { get; private set; }
        public static List<Tool> Tools { get; private set; }
        public static List<JobDefinition> Jobs { get; private set; }

        static GameData()
        {
            Industries = new List<Industry>();
            Workshops = new List<Workshop>();
            Tools = new List<Tool>();
            Jobs = new List<JobDefinition>();

            Initialize();
        }

        private static void Initialize()
        {
            // Industries
            var woodworking = new Industry("Woodworking");
            var stoneworking = new Industry("Stoneworking");
            var miningMetal = new Industry("Mining & Metal");
            var farmingFood = new Industry("Farming & Food");
            var textile = new Industry("Textile");
            var animalHusbandry = new Industry("Animal Husbandry");
            var craftingGeneral = new Industry("Crafting (General)");
            var paperScribing = new Industry("Paper and Scribing");
            var alchemyMagic = new Industry("Alchemy / Magic");
            var engineeringMechanics = new Industry("Engineering / Mechanics");
            var constructionBuilding = new Industry("Construction / Building");
            var militaryDefense = new Industry("Military & Defense");
            var administrative = new Industry("Administrative Roles");
            var clockworkAutomation = new Industry("Clockwork / Automation");
            var gemCutting = new Industry("Gem Cutting & Setting");
            var ceramicsPottery = new Industry("Ceramics / Pottery");

            Industries.AddRange(new[] { woodworking, stoneworking, miningMetal, farmingFood, textile, animalHusbandry, craftingGeneral, paperScribing, alchemyMagic, engineeringMechanics, constructionBuilding, militaryDefense, administrative, clockworkAutomation, gemCutting, ceramicsPottery });

            // Workshops
            var carpentryWorkshop = new Workshop("Carpentry Workshop");
            var bowyerWorkshop = new Workshop("Bowyer's Workshop");
            var woodcraftWorkshop = new Workshop("Woodcraft Workshop");
            var masonWorkshop = new Workshop("Mason’s Workshop");
            var stonecraftWorkshop = new Workshop("Stonecraft Workshop");
            var engravingTable = new Workshop("Engraving Table");
            var smelter = new Workshop("Smelter");
            var forge = new Workshop("Forge");
            var anvilStation = new Workshop("Anvil Station");
            var metalsmithWorkshop = new Workshop("Metalsmith's Workshop");
            var butcherShop = new Workshop("Butcher’s Shop");
            var tannery = new Workshop("Tannery");
            var fishery = new Workshop("Fishery");
            var kitchen = new Workshop("Kitchen");
            var still = new Workshop("Still (for brewing)");
            var mill = new Workshop("Mill (for flour, etc.)");
            var loom = new Workshop("Loom");
            var spinningWheel = new Workshop("Spinning Wheel");
            var dyeWorkshop = new Workshop("Dye Workshop");
            var tailorWorkshop = new Workshop("Tailor’s Workshop");
            var milkingStation = new Workshop("Milking Station");
            var cheesePressWorkshop = new Workshop("Cheese Press");
            var craftsdwarfWorkshop = new Workshop("Craftsdwarf's Workshop");
            var jewelerWorkshop = new Workshop("Jeweler’s Workshop");
            var trinketBench = new Workshop("Trinket Bench");
            var scriptorium = new Workshop("Scriptorium");
            var paperMill = new Workshop("Paper Mill");
            var bookbindingWorkshop = new Workshop("Bookbinding Workshop");
            var alchemyLab = new Workshop("Alchemy Lab");
            var enchanterTable = new Workshop("Enchanter's Table");
            var potionBrewery = new Workshop("Potion Brewery");
            var mechanicWorkshop = new Workshop("Mechanic’s Workshop");
            var gearAssemblyStation = new Workshop("Gear Assembly Station");
            var draftingTable = new Workshop("Drafting Table");
            var trainingYard = new Workshop("Training Yard");
            var armory = new Workshop("Armory");
            var archeryRange = new Workshop("Archery Range");
            var office = new Workshop("Office");
            var meetingHall = new Workshop("Meeting Hall");
            var throneRoom = new Workshop("Throne Room");
            var clockworkLab = new Workshop("Clockwork Lab");
            var gearWorkshop = new Workshop("Gear Workshop");
            var gemcutterTable = new Workshop("Gemcutter’s Table");
            var jewelryBench = new Workshop("Jewelry Bench");
            var potterWheel = new Workshop("Potter’s Wheel");
            var kilnWorkshop = new Workshop("Kiln");
            var glazingStation = new Workshop("Glazing Station");

            Workshops.AddRange(new[] { carpentryWorkshop, bowyerWorkshop, woodcraftWorkshop, masonWorkshop, stonecraftWorkshop, engravingTable, smelter, forge, anvilStation, metalsmithWorkshop, butcherShop, tannery, fishery, kitchen, still, mill, loom, spinningWheel, dyeWorkshop, tailorWorkshop, milkingStation, cheesePressWorkshop, craftsdwarfWorkshop, jewelerWorkshop, trinketBench, scriptorium, paperMill, bookbindingWorkshop, alchemyLab, enchanterTable, potionBrewery, mechanicWorkshop, gearAssemblyStation, draftingTable, trainingYard, armory, archeryRange, office, meetingHall, throneRoom, clockworkLab, gearWorkshop, gemcutterTable, jewelryBench, potterWheel, kilnWorkshop, glazingStation });

            // Tools
            var axe = new Tool("Axe");
            var saw = new Tool("Saw");
            var hammer = new Tool("Hammer");
            var chisel = new Tool("Chisel");
            var plane = new Tool("Plane");
            var pickaxe = new Tool("Pickaxe");
            var trowel = new Tool("Trowel");
            var crucible = new Tool("Crucible");
            var tongs = new Tool("Tongs");
            var anvil = new Tool("Anvil");
            var sickle = new Tool("Sickle or Hoe");
            var mortarPestle = new Tool("Mortar & Pestle");
            var cleaver = new Tool("Cleaver");
            var cookingPots = new Tool("Cooking pots");
            var barrels = new Tool("Barrels");
            var tanningRack = new Tool("Tanning rack");
            var shears = new Tool("Shears");
            var spindle = new Tool("Spindle");
            var loomTool = new Tool("Loom");
            var needle = new Tool("Needle");
            var dyeVats = new Tool("Dye vats");
            var buckets = new Tool("Buckets");
            var cheesePressTool = new Tool("Cheese press");
            var leash = new Tool("Leash/harness");
            var tweezers = new Tool("Tweezers (for gems)");
            var files = new Tool("Files");
            var smallHammer = new Tool("Small hammer");
            var quill = new Tool("Quill");
            var inkpot = new Tool("Inkpot");
            var press = new Tool("Press");
            var scissors = new Tool("Scissors");
            var alembic = new Tool("Alembic");
            var cauldron = new Tool("Cauldron");
            var enchantmentRunes = new Tool("Enchantment runes");
            var wrench = new Tool("Wrench");
            var gears = new Tool("Gears");
            var draftingTools = new Tool("Drafting tools");
            var measuringTape = new Tool("Measuring tape");
            var nails = new Tool("Nails");
            var measuringTools = new Tool("Measuring tools");
            var weapons = new Tool("Weapons (swords, bows, spears)");
            var dummies = new Tool("Dummies (for training)");
            var quillAndLedger = new Tool("Quill & Ledger");
            var sealsAndStamps = new Tool("Seals & Stamps");
            var precisionScrewdriver = new Tool("Precision screwdriver");
            var springsGears = new Tool("Springs/gears");
            var magnifyingLens = new Tool("Magnifying lens");
            var jewelerLoupe = new Tool("Jeweler’s loupe");
            var gemSaw = new Tool("Gem saw");
            var polishingTools = new Tool("Polishing tools");
            var clayTools = new Tool("Clay tools");
            var kilnTool = new Tool("Kiln");
            var brushes = new Tool("Brushes");

            Tools.AddRange(new[] { axe, saw, hammer, chisel, plane, pickaxe, trowel, crucible, tongs, anvil, sickle, mortarPestle, cleaver, cookingPots, barrels, tanningRack, shears, spindle, loomTool, needle, dyeVats, buckets, cheesePressTool, leash, tweezers, files, smallHammer, quill, inkpot, press, scissors, alembic, cauldron, enchantmentRunes, wrench, gears, draftingTools, measuringTape, nails, measuringTools, weapons, dummies, quillAndLedger, sealsAndStamps, precisionScrewdriver, springsGears, magnifyingLens, jewelerLoupe, gemSaw, polishingTools, clayTools, kilnTool, brushes });

            // Jobs
            Jobs.Add(new JobDefinition("Woodcutter", woodworking, null, new List<Tool> { axe }));
            Jobs.Add(new JobDefinition("Carpenter", woodworking, carpentryWorkshop, new List<Tool> { saw, hammer, chisel, plane }));
            Jobs.Add(new JobDefinition("Bowyer", woodworking, bowyerWorkshop, new List<Tool> { saw, chisel, plane }));
            Jobs.Add(new JobDefinition("Woodcrafter", woodworking, woodcraftWorkshop, new List<Tool> { saw, chisel }));
            Jobs.Add(new JobDefinition("Stone Miner", stoneworking, null, new List<Tool> { pickaxe }));
            Jobs.Add(new JobDefinition("Mason", stoneworking, masonWorkshop, new List<Tool> { hammer, chisel, trowel }));
            Jobs.Add(new JobDefinition("Stonecrafter", stoneworking, stonecraftWorkshop, new List<Tool> { hammer, chisel }));
            Jobs.Add(new JobDefinition("Engraver", stoneworking, engravingTable, new List<Tool> { hammer, chisel }));
            Jobs.Add(new JobDefinition("Miner", miningMetal, null, new List<Tool> { pickaxe }));
            Jobs.Add(new JobDefinition("Smelter", miningMetal, smelter, new List<Tool> { crucible, tongs }));
            Jobs.Add(new JobDefinition("Blacksmith", miningMetal, forge, new List<Tool> { hammer, tongs, anvil }));
            Jobs.Add(new JobDefinition("Weaponsmith", miningMetal, forge, new List<Tool> { hammer, tongs, anvil }));
            Jobs.Add(new JobDefinition("Armorsmith", miningMetal, forge, new List<Tool> { hammer, tongs, anvil }));
            Jobs.Add(new JobDefinition("Metalcrafter", miningMetal, metalsmithWorkshop, new List<Tool> { hammer, tongs }));
            Jobs.Add(new JobDefinition("Farmer (Field Crops)", farmingFood, null, new List<Tool> { sickle }));
            Jobs.Add(new JobDefinition("Herbalist (Wild Plants)", farmingFood, null, new List<Tool> { sickle }));
            Jobs.Add(new JobDefinition("Miller", farmingFood, mill, new List<Tool>()));
            Jobs.Add(new JobDefinition("Cook", farmingFood, kitchen, new List<Tool> { cookingPots }));
            Jobs.Add(new JobDefinition("Brewer", farmingFood, still, new List<Tool> { barrels }));
            Jobs.Add(new JobDefinition("Butcher", farmingFood, butcherShop, new List<Tool> { cleaver }));
            Jobs.Add(new JobDefinition("Tanner", farmingFood, tannery, new List<Tool> { tanningRack }));
            Jobs.Add(new JobDefinition("Fisherman", farmingFood, fishery, new List<Tool>()));
            Jobs.Add(new JobDefinition("Fish Cleaner", farmingFood, fishery, new List<Tool>()));
            Jobs.Add(new JobDefinition("Shearer", textile, null, new List<Tool> { shears }));
            Jobs.Add(new JobDefinition("Spinner", textile, spinningWheel, new List<Tool> { spindle }));
            Jobs.Add(new JobDefinition("Weaver", textile, loom, new List<Tool> { loomTool }));
            Jobs.Add(new JobDefinition("Dyer", textile, dyeWorkshop, new List<Tool> { dyeVats }));
            Jobs.Add(new JobDefinition("Tailor", textile, tailorWorkshop, new List<Tool> { needle }));
            Jobs.Add(new JobDefinition("Animal Trainer", animalHusbandry, null, new List<Tool> { leash }));
            Jobs.Add(new JobDefinition("Milker", animalHusbandry, milkingStation, new List<Tool> { buckets }));
            Jobs.Add(new JobDefinition("Cheese Maker", animalHusbandry, cheesePressWorkshop, new List<Tool> { cheesePressTool }));
            Jobs.Add(new JobDefinition("Rancher", animalHusbandry, null, new List<Tool>()));
            Jobs.Add(new JobDefinition("Crafter", craftingGeneral, craftsdwarfWorkshop, new List<Tool> { chisel, files, smallHammer }));
            Jobs.Add(new JobDefinition("Jeweler", craftingGeneral, jewelerWorkshop, new List<Tool> { chisel, tweezers, files, smallHammer }));
            Jobs.Add(new JobDefinition("Toymaker", craftingGeneral, trinketBench, new List<Tool> { smallHammer, files }));
            Jobs.Add(new JobDefinition("Trapmaker", craftingGeneral, craftsdwarfWorkshop, new List<Tool> { saw, hammer }));
            Jobs.Add(new JobDefinition("Scribe", paperScribing, scriptorium, new List<Tool> { quill, inkpot }));
            Jobs.Add(new JobDefinition("Bookbinder", paperScribing, bookbindingWorkshop, new List<Tool> { press, scissors, needle }));
            Jobs.Add(new JobDefinition("Paper Maker", paperScribing, paperMill, new List<Tool> { press }));
            Jobs.Add(new JobDefinition("Archivist", paperScribing, office, new List<Tool> { quill, inkpot }));
            Jobs.Add(new JobDefinition("Alchemist", alchemyMagic, alchemyLab, new List<Tool> { mortarPestle, alembic, cauldron }));
            Jobs.Add(new JobDefinition("Herbalist", alchemyMagic, alchemyLab, new List<Tool> { mortarPestle }));
            Jobs.Add(new JobDefinition("Enchanter", alchemyMagic, enchanterTable, new List<Tool> { enchantmentRunes }));
            Jobs.Add(new JobDefinition("Mechanic", engineeringMechanics, mechanicWorkshop, new List<Tool> { wrench, gears }));
            Jobs.Add(new JobDefinition("Architect", engineeringMechanics, draftingTable, new List<Tool> { draftingTools, measuringTape }));
            Jobs.Add(new JobDefinition("Engineer", engineeringMechanics, gearAssemblyStation, new List<Tool> { wrench, gears }));
            Jobs.Add(new JobDefinition("Builder", constructionBuilding, null, new List<Tool> { hammer, nails, measuringTools, trowel }));
            Jobs.Add(new JobDefinition("Carpenter", constructionBuilding, null, new List<Tool> { saw, hammer, nails, measuringTools }));
            Jobs.Add(new JobDefinition("Mason", constructionBuilding, null, new List<Tool> { hammer, trowel, measuringTools }));
            Jobs.Add(new JobDefinition("Soldier", militaryDefense, trainingYard, new List<Tool> { weapons, dummies }));
            Jobs.Add(new JobDefinition("Guard", militaryDefense, armory, new List<Tool> { weapons }));
            Jobs.Add(new JobDefinition("Archer", militaryDefense, archeryRange, new List<Tool> { weapons, dummies }));
            Jobs.Add(new JobDefinition("Trainer (for squads)", militaryDefense, trainingYard, new List<Tool> { dummies }));
            Jobs.Add(new JobDefinition("Mayor", administrative, throneRoom, new List<Tool> { sealsAndStamps }));
            Jobs.Add(new JobDefinition("Clerk", administrative, office, new List<Tool> { quillAndLedger }));
            Jobs.Add(new JobDefinition("Accountant", administrative, office, new List<Tool> { quillAndLedger }));
            Jobs.Add(new JobDefinition("Diplomat", administrative, meetingHall, new List<Tool> { sealsAndStamps }));
            Jobs.Add(new JobDefinition("Tinkerer", clockworkAutomation, clockworkLab, new List<Tool> { precisionScrewdriver, springsGears, magnifyingLens }));
            Jobs.Add(new JobDefinition("Machinist", clockworkAutomation, gearWorkshop, new List<Tool> { wrench, gears, files }));
            Jobs.Add(new JobDefinition("Gem Cutter", gemCutting, gemcutterTable, new List<Tool> { jewelerLoupe, gemSaw, polishingTools }));
            Jobs.Add(new JobDefinition("Gem Setter", gemCutting, jewelryBench, new List<Tool> { jewelerLoupe, smallHammer, tweezers }));
            Jobs.Add(new JobDefinition("Potter", ceramicsPottery, potterWheel, new List<Tool> { clayTools }));
            Jobs.Add(new JobDefinition("Kiln Operator", ceramicsPottery, kilnWorkshop, new List<Tool> { kilnTool }));
            Jobs.Add(new JobDefinition("Glazer", ceramicsPottery, glazingStation, new List<Tool> { brushes }));
        }
    }
}
