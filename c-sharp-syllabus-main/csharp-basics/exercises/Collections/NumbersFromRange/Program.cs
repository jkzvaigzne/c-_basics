using System;
using System.Collections.Generic;
using System.Linq;

namespace NumbersFromRange
{
    internal class Program
    {
        private const int MinRmdVal = 1;
        private const int MaxRmdVal = 100;
        private const int minRange = 30;
        private const int maxRange = 100;
        private const int numOfRmdNums = 10;

        static void Main(string[] args)
        {
            var rnd = new Random();
            var nums = new List<int>();

            while (nums.Count < numOfRmdNums)
            {
                nums.Add(rnd.Next(MinRmdVal, MaxRmdVal));
            }

            var numsInRange = new List<int>();
            foreach (var num in nums)
            {
                if (num > minRange && num < maxRange)
                {
                    numsInRange.Add(num);
                    Console.WriteLine($"number {num} is greater than {minRange} and less than {maxRange}");
                }
            }

            Console.Read();
        }
    }
}
