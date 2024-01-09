using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleFight
{
    internal interface IGameCharacters
    {
        string Name { get; set;  }
        int Health { get; set; }
        int AttackPower { get; set; }
        void Attack(IGameCharacters opponent);
        void Defend(int damage);
        void DisplayInfo();
    }
}
