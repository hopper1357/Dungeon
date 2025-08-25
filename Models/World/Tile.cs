namespace Dungeon.Models.World
{
    public class Tile
    {
        public TileType Type { get; set; }

        public Tile(TileType type)
        {
            Type = type;
        }
    }
}
