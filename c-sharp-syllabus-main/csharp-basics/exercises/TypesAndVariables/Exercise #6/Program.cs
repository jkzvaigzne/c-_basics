using System;

namespace Exercise__6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadi pirmo ciparu un spied 'Enter'. Cipariem jābūt no 0-9: ");
            int userFirstNumber = ReadSingleDigitNumber();

            Console.WriteLine("Ievadi otro ciparu un spied 'Enter'. Cipariem jābūt no 0-9: ");
            int userSecondNumber = ReadSingleDigitNumber();

            int totalSum = userFirstNumber + userSecondNumber;
            Console.WriteLine($"Skaitļu summa {userFirstNumber} un {userSecondNumber} ir: {totalSum}");
            
            Console.ReadLine();
        }

        static int ReadSingleDigitNumber()
        {
            int number;

            while (!int.TryParse(Console.ReadLine(), out number) || number < 0 || number > 9)
            {
                Console.WriteLine("To ko? Mēs taču sarunājām no 0-9:");
            }
            return number;
        }
    }
}
