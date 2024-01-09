using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleFight
{
    internal class BattleSystem
    {
        public void StartBattle(IGameCharacters player1,  IGameCharacters player2)
        {
            Console.WriteLine("Battle Start!");
            while (player1.Health > 0 && player2.Health > 0)
            {
                player1.Attack(player2);
                if (player2.Health <= 0) break; 
                player2.Attack(player1);
            }

            Console.WriteLine(player1.Health > 0 ? $"{player1.Name} wins!" : $"{player2.Name} wins!");
        }
    }
    }

