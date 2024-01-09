using BattleFight;
using System.Threading;

class Program
{
    static void Main()
    {
        MainCharacter player1 = new MainCharacter("Warrior", 0, 0, 0);
        Boss player2 = new Boss("Wizard", 0, 0, 0);

        RandomStats(player1);
        RandomStats(player2);

        BattleSystem battleSystem = new BattleSystem();
        battleSystem.StartBattle(player1, player2);
    }

    public static void RandomStats(IGameCharacters character)
    {
        Random stats = new Random();

        character.Health = stats.Next(50, 200);
        character.AttackPower = stats.Next(10, 50);

        if (character is MainCharacter mainCharacter)
        {
            mainCharacter.Rage = stats.Next(0, 5);
        }
        else if (character is Boss boss)
        {
            boss.Mana = stats.Next(20, 100);
        }
    }
}
