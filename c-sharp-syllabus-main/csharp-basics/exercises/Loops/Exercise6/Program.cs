using System;

namespace Exercise6
{
    internal class Program
    {
        static void Main()
        {
            int maxValue;
            bool isValidInput = false;

            do
            {
                Console.Write("Enter positive number:");
                if (int.TryParse(Console.ReadLine(), out maxValue) && maxValue > 0)
                {
                    isValidInput = true;
                }
                else
                {
                    Console.WriteLine("Please enter positive integer.");
                }
            } while (!isValidInput);

            OutputFizzBuzz(maxValue);
            Console.ReadKey();
        }

        static void OutputFizzBuzz(int maxValue)
        {
            for (int i = 1; i <= maxValue; i++)
            {
                string result = (i % 3 == 0 && i % 5 == 0) ? "FizzBuzz" :
                                (i % 3 == 0) ? "Fizz" :
                                (i % 5 == 0) ? "Buzz" : i.ToString();

                Console.Write(result + ((i % 20 == 0) ? "\n" : " "));
            }
        }
    }
}
