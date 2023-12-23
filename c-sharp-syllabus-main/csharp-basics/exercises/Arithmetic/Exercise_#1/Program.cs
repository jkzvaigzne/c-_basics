using System;

namespace Exercise__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadi pirmo skaitli: ");
            int userChoiceFirst = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Tu ievadīji: {userChoiceFirst}");

            Console.Write("Ievadi otro skaitli: ");
            int userChoiceSecond = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Tu ievadīji: {userChoiceSecond}");

            bool checkConditions = CheckConditions(userChoiceFirst, userChoiceSecond);

            Console.WriteLine($"Rezultāts: {checkConditions}");
            Console.Read();
        }

        static bool CheckConditions(int numberOne, int numberTwo)
        {
            return (numberOne == 15 || numberTwo == 15 || numberOne + numberTwo == 15 || numberOne * numberTwo == 15);
        }
    }
}
