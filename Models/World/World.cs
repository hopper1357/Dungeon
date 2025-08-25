using System.Collections.Generic;

namespace Dungeon.Models.World
{
    public class World
    {
        public Tile[,,] Tiles { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        public int Depth { get; private set; }
        public List<Zone> Zones { get; private set; }

        public World(int width, int height, int depth)
        {
            Width = width;
            Height = height;
            Depth = depth;
            Tiles = new Tile[width, height, depth];
            Zones = new List<Zone>();
        }
    }
}
