using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int minNumber = 1;
            int maxNumber = 10;

            for (int input = minNumber; input <= maxNumber; input++)
            {
                Console.WriteLine($"{maxNumber} natural numbers are: {input}");
            }

            Console.Read();
        }
    }
}
