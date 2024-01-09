using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleFight
{
    internal class MainCharacter : Character, IGameCharacters
    {
        public int Rage { get; set; }

        public MainCharacter(string name, int health, int attackPower, int rage)
            : base(name, health, attackPower)
        {
            Rage = rage;
        }

        public override void Attack(IGameCharacters opponent)
        {
            int totalDamage = AttackPower + (Rage > 0 ? 10 : 0);
            Console.WriteLine($"{Name} swings a mighty sword!");
            opponent.Defend(totalDamage);
            Rage--; 
        }
    }
}
