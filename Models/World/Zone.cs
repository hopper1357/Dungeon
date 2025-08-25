namespace Dungeon.Models.World
{
    public class Zone
    {
        public ZoneType Type { get; set; }
        public Rect Area { get; set; }
        public int Z { get; set; }

        public Zone(ZoneType type, Rect area, int z)
        {
            Type = type;
            Area = area;
            Z = z;
        }
    }
}
