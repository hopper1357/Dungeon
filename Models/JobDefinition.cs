using System.Collections.Generic;

namespace Dungeon.Models
{
    public class JobDefinition
    {
        public string Name { get; set; }
        public Industry Industry { get; set; }
        public Workshop? Workshop { get; set; }
        public List<Tool> Tools { get; set; }

        public JobDefinition(string name, Industry industry, Workshop? workshop, List<Tool> tools)
        {
            Name = name;
            Industry = industry;
            Workshop = workshop;
            Tools = tools;
        }
    }
}
