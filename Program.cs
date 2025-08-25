using Dungeon.Models;

namespace Dungeon
{
    class Program
    {

        private bool isRunning = true;
        private const int FramsPerSecond = 60;
        private const double UpdateInterval = 1000.0 / FramsPerSecond;
        private List<Dwarf> dwarves = new List<Dwarf>();

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
            Dwarf dwarf1 = new Dwarf(100, 100, 100, 10, 10, 10, 25, Job.Miner);
            dwarf1.Skills.Add(new Skill("Mining", 5));
            dwarf1.Skills.Add(new Skill("Fighting", 2));
            dwarves.Add(dwarf1);

            Dwarf dwarf2 = new Dwarf(80, 80, 80, 8, 12, 10, 30, Job.Farmer);
            dwarf2.Skills.Add(new Skill("Farming", 4));
            dwarf2.Skills.Add(new Skill("Cooking", 3));
            dwarves.Add(dwarf2);
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
                Console.WriteLine($"Job: {dwarf.CurrentJob}");
                Console.WriteLine("Skills:");
                foreach (var skill in dwarf.Skills)
                {
                    Console.WriteLine($"- {skill.Name} (Level {skill.Level})");
                }
                Console.WriteLine();
            }
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