using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace BattleFight
{
    internal class Boss : Character, IGameCharacters
    {
        public int Mana { get; set; }

        public Boss(string name, int health, int attackpower, int mana)
            : base(name, health, attackpower)
        {
            Mana = mana;
        }

        public override void Attack(IGameCharacters opponent)
        {
            if (Mana >= 20)
            {
                Console.WriteLine($"{Name} casts a fireball!");
                opponent.Defend(AttackPower + 30);
                Mana -= 20;
            }
            else
            {
                base.Attack(opponent);
            }
        }
    }
}
