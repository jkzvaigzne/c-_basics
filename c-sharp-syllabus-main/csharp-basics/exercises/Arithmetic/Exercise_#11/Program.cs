using System;

namespace Exercise__11
{
    internal class Program
    {
        static bool PrimeChecker(int number)
        {
            if (number <= 1) return false;
            if (number == 2 || number == 3) return true;
            if (number % 2 == 0 || number % 3 == 0) return false;

            int sqrt = (int)Math.Sqrt(number);
            for (int i = 5; i * i <= number; i +=6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                    return false;
            }
            return true;
        }

        static int SumOfDigits(int num)
        {
            int sum = 0;

            foreach (char digit in num.ToString())
            {
                sum += digit - '0';
            }
            return sum;
        }

        static string CheckMoran(int number)
        {
            int sum = SumOfDigits(number);
            return number % sum == 0 ? PrimeChecker(number / sum) ? "M" : "H" : "Neither";
        }

        static void Main(string[] args)
        {
            Console.WriteLine(CheckMoran(132));
            Console.WriteLine(CheckMoran(133));
            Console.WriteLine(CheckMoran(134));
            Console.Read();
        }
    }
}
