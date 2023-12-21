using System;

namespace Exercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadi vardu");
            string userChoice = Console.ReadLine();

            int counter = 0;
            foreach (char bigLetters in userChoice)
            {
                if (char.IsUpper(bigLetters))
                {
                    counter++;
                }
            }

            Console.WriteLine($"Lielie burti vardā: {counter}");
            Console.ReadLine();
        }
    }
}
