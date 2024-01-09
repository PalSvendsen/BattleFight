using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleFight
{
    internal class Character : IGameCharacters
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public Character(string name, int health, int attackpower)
        {
            Name = name;
            Health = health;
            AttackPower = attackpower;
        }
        public virtual void Attack(IGameCharacters opponent)
        {
            Console.WriteLine($"{Name} attacks {opponent.Name}!");
            opponent.Defend(AttackPower);
        }
        public virtual void Defend(int damage)
        {
            Health -= damage;
            Console.WriteLine($"{Name} takes {damage} damage!");
            DisplayInfo();
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"{Name} | Health: {Health}");
        }
    }
}
