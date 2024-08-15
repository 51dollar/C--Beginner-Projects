using System;

namespace TurnBased
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int playerHp = rand.Next(20, 41);
            int enemyHp = rand.Next(5, 41);

            int playerAttack = rand.Next(1, 11);
            int enemyAttack = rand.Next(1, 11);

            int healAmount = rand.Next(1, 5);

            

            while (playerHp > 0 && enemyHp > 0)
            {
                // Player turn
                Console.WriteLine("-- Player turn --");
                Console.WriteLine("Player Hp - " + playerHp + ".Enemy Hp - " + enemyHp + ".");
                Console.WriteLine("Enter 'a' to attack or 'h' to heal.");

                string choice = Console.ReadLine().ToLower();

                if(choice == "a")
                {
                    enemyHp -= playerAttack;
                    Console.WriteLine("Player attack enemy and deals " + playerAttack + " damage!");
                }
                else
                {
                    playerHp += healAmount;
                    Console.WriteLine("Player restores " + healAmount + " health points!");
                }

                // Enemy turn
                if (enemyHp > 0)
                {
                    Console.WriteLine("-- Enemy turn --");
                    Console.WriteLine("Player Hp - " + playerHp + ".Enemy Hp - " + enemyHp + ".");

                    int enemyChoice = rand.Next(0, 2);

                    if (enemyChoice == 0)
                    {
                        playerHp -= enemyAttack;
                        Console.WriteLine("Enemy attacks and deals " + enemyAttack + " damage!");
                    }
                    else
                    {
                        enemyHp += healAmount;
                        Console.WriteLine("Enemy restores " + healAmount + " health points!");
                    }
                }
            }

            if(playerHp > 0)
            {
                Console.WriteLine("Congratulations, you have won!");
            }
            else
            {
                Console.WriteLine("You lose!");
            }

            Console.ReadKey();
        }
    }
}