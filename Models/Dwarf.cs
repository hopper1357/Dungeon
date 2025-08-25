using System.Collections.Generic;

namespace Dungeon.Models
{
    public class Dwarf
    {
        public int Health { get; set; }
        public int Hunger { get; set; }
        public int Stamina { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Age { get; set; }
        public Job CurrentJob { get; set; }
        public List<Skill> Skills { get; set; }

        public Dwarf(int health, int hunger, int stamina, int strength, int dexterity, int intelligence, int age, Job currentJob)
        {
            Health = health;
            Hunger = hunger;
            Stamina = stamina;
            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;
            Age = age;
            CurrentJob = currentJob;
            Skills = new List<Skill>();
        }
    }
}
