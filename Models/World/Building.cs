namespace Dungeon.Models.World
{
    public class Building
    {
        public Workshop Workshop { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Building(Workshop workshop, int x, int y, int z)
        {
            Workshop = workshop;
            X = x;
            Y = y;
            Z = z;
        }
    }
}
