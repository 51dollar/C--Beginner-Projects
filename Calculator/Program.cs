using System;

namespace Calculator
{
    internal class Program
    {

        static void Main(string[] args)
        {
            float num1;
            float num2;
            float result;

            string answer;
            char restart;

            Console.WriteLine("Hello, welcom to the calculator program!");

            do
            {
                Console.WriteLine("Please enter your first number.");

                num1 = float.Parse(Console.ReadLine());

                Console.WriteLine("Please enter your second number.");

                num2 = float.Parse(Console.ReadLine());

                Console.WriteLine("What type of operation would you like to do?");
                Console.WriteLine("Please enter 1 for addition, 2 for subtraction, 3 fot multiplacation or any other key for division.");

                answer = Console.ReadLine();

                if (answer == "1")
                {
                    result = num1 + num2;
                }
                else if (answer == "2")
                {
                    result = num1 - num2;
                }
                else if (answer == "3")
                {
                    result = num1 * num2;
                }
                else
                {
                    result = num2 == 0 ? float.NaN : num1 / num2;
                }

                if (float.IsNaN(result))
                {
                    Console.WriteLine("Cannot divide by 0!");
                }
                else
                {
                    Console.WriteLine("The result is " + result);
                }

                Console.WriteLine("Thank you for using the calculator program!");
                Console.WriteLine("Repeat? y/n");

                restart = Convert.ToChar(Console.ReadLine());

            }
            while (restart == 'y');
        }
    }
}