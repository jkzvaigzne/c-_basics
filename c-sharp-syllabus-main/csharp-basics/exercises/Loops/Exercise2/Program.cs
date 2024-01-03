using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = GetUserNumber();
            int res = MakePowerNumber(num);
            DisplayOutput(res);

            Console.Read();
        }

        static int GetUserNumber()
        {
            Console.WriteLine("Input number : ");
            int userChoiceNumber = int.Parse(Console.ReadLine());
            return userChoiceNumber;
        }

        static int MakePowerNumber(int num)
        {
            int res = 1;

            for (int i = 0; i < num; i++)
            {
                res *= num;
            }

            return res;
        }

        static void DisplayOutput(int res)
        {
            Console.WriteLine($"Result: {res}");
        }
    }
}
