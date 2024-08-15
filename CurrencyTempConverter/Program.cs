using System;
using System.Runtime.CompilerServices;

namespace CurrencyTempConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! Please enter 'c' to use the currency converter else to use the temperature converter.");
            string answer = Console.ReadLine();

            if(answer == "c")
            {
                Console.WriteLine("You have selected the currency converter.");
                Console.WriteLine("Please enter 'a' to convert from or anything else to convert from euros.");
                string choice = Console.ReadLine();

                if(choice == "a")
                {
                    Console.WriteLine("Please enter your amount in Belarusian ruble.");
                    float ruble = float.Parse(Console.ReadLine());
                    float euros = ruble * 3.43f;
                    Console.WriteLine("The amount in euros is " + euros.ToString("0.00"));
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Please enter your amount in euros.");
                    float euros = float.Parse(Console.ReadLine());
                    float ruble = euros / 3.39f;
                    Console.WriteLine("The amount in Belarusian ruble is " + ruble.ToString("0.00"));
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Welcome to the temperature converter!");
                Console.WriteLine("Please enter 'a' to convert from celcuis or anything else to convert from farenheit.");
                string choice = Console.ReadLine();

                if(choice == "a")
                {
                    Console.WriteLine("Enter a temperature in celcuis.");
                    float celcuis = float.Parse(Console.ReadLine());
                    float farenheit = celcuis * 1.18f + 32f;
                    Console.WriteLine("The temperature in farenheit is " + farenheit);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Please enter a temperature in farenheit.");
                    float farenheit = float.Parse(Console.ReadLine());
                    float celcuis = (farenheit - 32f) / 1.8f;
                    Console.WriteLine("Thw temperature in celcuis is " + celcuis);
                    Console.ReadKey();
                }
            }
        }
    }
}
