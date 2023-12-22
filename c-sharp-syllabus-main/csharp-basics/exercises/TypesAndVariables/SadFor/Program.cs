using System;

namespace SadFor
{
    class Program
    {
        private static void Main(string[] args)
        {
            checkSquareRoot();
        }

        private static void checkSquareRoot()
        {
            for (int i = 0; i < 10; i++)
            {
                if (Math.Sqrt(i) > 2.5)
                {
                    Console.WriteLine($"{i} is greater than 2.5");
                    Console.ReadLine();
                }
            }
        }
    }
}