using System;

namespace GuessGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isCorrecteGuess = false;
            Random random = new Random();

            int randomNum = random.Next(1, 11);

            Console.WriteLine("Welcome to the number guessing game!\n" +
                "A number betwwen 1 and 10 will be generated.\n" +
                "If you guess the correct number, you win!");

            while (!isCorrecteGuess)
            {
                Console.WriteLine("Please enter your guess.");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess > randomNum)
                {
                    Console.WriteLine("Your guess is too high.");
                }
                else if (guess < randomNum)
                {
                    Console.WriteLine("Your guess is too low.");
                }
                else
                {
                    Console.WriteLine("Correct!");
                    isCorrecteGuess = true;
                }
            }

            Console.WriteLine("Congratulations, you have won the game!");

            Console.ReadKey();
        }
    }
}