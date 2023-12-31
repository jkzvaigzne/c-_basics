using System;

namespace TenBillion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input an integer number less than ten billion: ");

            CheckNumber();
            Console.Read();
        }

        static void CheckNumber()
        {
            var input = Console.ReadLine();
            long tenBillion = 10000000000;

            var validInput = long.TryParse(input, out long number) && number >= 0 && number <= tenBillion;

            Console.WriteLine(validInput ?
                $"The number {number} has {(number < 10 ? 1 : digitsCounter(number))} digits."
                : "Invalid input.");
        }

        static int digitsCounter(long number)
        {
            int counter = 1;

            while (number >= 10)
            {
                number /= 10;
                counter++;
            }

            return counter;
        }
    }
}
