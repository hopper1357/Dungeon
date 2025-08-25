using Dungeon.Models.World;

namespace Dungeon.Generators
{
    public class WorldGenerator
    {
        public World Generate(int width, int height, int depth)
        {
            var world = new World(width, height, depth);
            int surfaceLevel = depth / 2;

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    for (int z = 0; z < depth; z++)
                    {
                        if (z < surfaceLevel)
                        {
                            world.Tiles[x, y, z] = new Tile(TileType.Air);
                        }
                        else if (z == surfaceLevel)
                        {
                            world.Tiles[x, y, z] = new Tile(TileType.Grass);
                        }
                        else if (z > surfaceLevel && z <= surfaceLevel + 3)
                        {
                            world.Tiles[x, y, z] = new Tile(TileType.Dirt);
                        }
                        else
                        {
                            world.Tiles[x, y, z] = new Tile(TileType.Stone);
                        }
                    }
                }
            }

            return world;
        }
    }
}
