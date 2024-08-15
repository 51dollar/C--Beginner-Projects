using System;

namespace Dice_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int enemyRandomNum;

            int playerPoints = 0;
            int enemyPoints = 0;

            string update;
            string restart;

            do
            {
                Random rand = new Random();

                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Raund: {i + 1}");
                    Console.WriteLine("Press any key to roll the dice.");

                    Console.ReadKey();

                    playerRandomNum = rand.Next(1, 7);
                    Console.WriteLine("Yor rolled a " + playerRandomNum);

                    Console.WriteLine("...");
                    System.Threading.Thread.Sleep(500);

                    enemyRandomNum = rand.Next(1, 7);
                    Console.WriteLine("Enemy AI rolled a " + enemyRandomNum);

                    if (playerRandomNum > enemyRandomNum)
                    {
                        playerPoints++;
                        Console.WriteLine("Player wins this round!");
                    }
                    else if (playerRandomNum < enemyRandomNum)
                    {
                        enemyRandomNum++;
                        Console.WriteLine("Enemy wins this round!");
                    }
                    else
                    {
                        Console.WriteLine("Draw!");
                    }

                    Console.WriteLine("The scorw is now - Player : " + playerPoints + ". Enemy : " + enemyPoints + ".");
                    Console.WriteLine();
                }

                if (playerPoints > enemyPoints)
                {
                    Console.WriteLine("____________________________________________________________________________________________________________________\n" +
                        "\nYou win!");
                }
                else if (playerPoints < enemyPoints)
                {
                    Console.WriteLine("You lose!");
                }
                else
                {
                    Console.WriteLine("it's a draw!");
                }

                Console.WriteLine();
                Console.WriteLine("Restart? y/n");

                restart = Console.ReadLine().ToLower();
            }
            while (restart == "y");
        }
    }
}