namespace Dungeon
{
    class Program
    {

        private bool isRunning = true;
        private const int FramsPerSecond = 60;
        private const double UpdateInterval = 1000.0 / FramsPerSecond;

        public void Run()
        {
            Initialize();

            double previousUpdateTime = Environment.TickCount;

            while (isRunning)
            {
                double currentTime = Environment.TickCount;
                double elapsedTime = currentTime - previousUpdateTime;

                if (elapsedTime >= UpdateInterval)
                {
                    Update();
                    Draw();
                    previousUpdateTime = currentTime;

                }
                else
                {
                    int sleepTime = (int)(UpdateInterval - elapsedTime);
                    if(sleepTime > 0)
                    {
                        Thread.Sleep(sleepTime);
                    }

                }

            }
            Cleanup();

        }

        private void Initialize()
        {
            // Initialize game resources and system here
        }

        private void Update()
        {
            // Update game logic, simulate dwarves, and handle input
            Console.WriteLine("Update");
            if (Console.KeyAvailable)
            {

                var key = Console.ReadKey(intercept: true).Key;
                if (key == ConsoleKey.Q)
                {
                    Exit();
                }
            }

        }

        private void Draw()
        {

            // Render the game world, dwarves, and UI
            Console.WriteLine("Draw");

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