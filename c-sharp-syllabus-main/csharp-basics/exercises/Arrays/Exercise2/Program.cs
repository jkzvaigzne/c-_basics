using System;

namespace Exercise2
{
    class Program
    {   
        private static int SumValues(int minNum, int maxNum)
        {
            int result = 0;
            for(int i = minNum; i <= maxNum; i++)
            {
                result += i;
            }

            return result;
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Please enter a min number");
            int minNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a max number");
            int maxNumber = int.Parse(Console.ReadLine());

            int sum = SumValues(minNumber, maxNumber);

            Console.WriteLine("The sum is " + sum);
            Console.ReadKey();
        }
    }
}
