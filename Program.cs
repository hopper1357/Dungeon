using Dungeon.Models;
using System.Linq;

namespace Dungeon
{
    class Program
    {

        private bool isRunning = true;
        private const int FramsPerSecond = 60;
        private const double UpdateInterval = 1000.0 / FramsPerSecond;
        private List<Dwarf> dwarves = new List<Dwarf>();
        private Stockpile stockpile = new Stockpile();

        public void Run()
        {
            Initialize();

            double previousUpdateTime = Environment.TickCount;

            Update();
            Draw();
            Cleanup();

        }

        private void Initialize()
        {
            // Initialize game resources and system here
            var minerJob = GameData.Jobs.First(j => j.Name == "Miner");
            Dwarf dwarf1 = new Dwarf(100, 100, 100, 10, 10, 10, 25, minerJob);
            dwarf1.Skills.Add(new Skill("Mining", 5));
            dwarf1.Skills.Add(new Skill("Fighting", 2));
            dwarf1.Inventory.Add(new Item("Pickaxe", 1));
            dwarves.Add(dwarf1);

            var farmerJob = GameData.Jobs.First(j => j.Name == "Farmer (Field Crops)");
            Dwarf dwarf2 = new Dwarf(80, 80, 80, 8, 12, 10, 30, farmerJob);
            dwarf2.Skills.Add(new Skill("Farming", 4));
            dwarf2.Skills.Add(new Skill("Cooking", 3));
            dwarf2.Inventory.Add(new Item("Hoe", 1));
            dwarves.Add(dwarf2);

            stockpile.AddItem(new Item("Stone", 50));
            stockpile.AddItem(new Item("Wood", 25));
            stockpile.AddItem(new Item("Iron Ore", 10));
        }

        private void Update()
        {
            // Update game logic, simulate dwarves, and handle input
        }

        private void Draw()
        {
            Console.Clear();
            // Render the game world, dwarves, and UI
            foreach (var dwarf in dwarves)
            {
                Console.WriteLine("--- Dwarf ---");
                Console.WriteLine($"Health: {dwarf.Health}");
                Console.WriteLine($"Hunger: {dwarf.Hunger}");
                Console.WriteLine($"Stamina: {dwarf.Stamina}");
                Console.WriteLine($"Strength: {dwarf.Strength}");
                Console.WriteLine($"Dexterity: {dwarf.Dexterity}");
                Console.WriteLine($"Intelligence: {dwarf.Intelligence}");
                Console.WriteLine($"Age: {dwarf.Age}");
                Console.WriteLine($"Job: {dwarf.CurrentJob.Name}");
                Console.WriteLine("Skills:");
                foreach (var skill in dwarf.Skills)
                {
                    Console.WriteLine($"- {skill.Name} (Level {skill.Level})");
                }
                Console.WriteLine("Inventory:");
                foreach (var item in dwarf.Inventory)
                {
                    Console.WriteLine($"- {item.Name} (x{item.Quantity})");
                }
                Console.WriteLine();
            }

            Console.WriteLine("--- Stockpile ---");
            foreach (var item in stockpile.Items)
            {
                Console.WriteLine($"- {item.Name} (x{item.Quantity})");
            }
            Console.WriteLine();
        }

        private void Cleanup()
        {

            // Clean up any resources
            Console.WriteLine("Cleanup");
        }

        public void Exit()
        {
            isRunning = false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Program Launched");
            Program game = new Program();
            game.Run();
        }
    }
}