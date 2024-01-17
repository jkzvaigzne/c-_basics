using System;
using System.Linq;

namespace Exercise5
{
    internal class Program
    {
        static void Main()
        {
            int userChoiceNumber;

            while (true)
            {
                Console.WriteLine("enter valid number:");
                if (int.TryParse(Console.ReadLine(), out userChoiceNumber))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("invalid input. enter only number");
                }
            }

            bool isHappyOrSad = CheckForHappyNum(userChoiceNumber);

            Console.WriteLine(isHappyOrSad ? "happy :)" : "sad :(");
            Console.Read();
        }

        static bool CheckForHappyNum(int num)
        {
            const int maxNum = 10; 

            while (num >= maxNum)
            {
                num = SquareSumOfDigits(num);
            }

            return num == 1;
        }

        static int SquareSumOfDigits(int num)
        {
            return num.ToString().Sum(digit => (int)Math.Pow(digit - '0', 2));
        }
    }
}
