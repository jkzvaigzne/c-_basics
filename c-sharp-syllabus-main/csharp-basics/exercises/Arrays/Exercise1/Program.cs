using System;

namespace Exercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            int[] yearsArr =
            {
                1789, 2035, 1899, 1456, 2013,
                1458, 2458, 1254, 1472, 2365,
                1456, 2165, 1457, 2456
            };

            string[] languagesArr =
            {
                "Java",
                "Python",
                "PHP",
                "C#",
                "C Programming",
                "C++"
            };

            SortedNumericArr(yearsArr);
            SortedStringArr(languagesArr);
            
            Console.Read();
        }

        private static void SortedNumericArr(int[] array)
        {
            Array.Sort(array); 

            Console.WriteLine($"Original - Numeric array: {string.Join(",", array)}");
            Console.WriteLine($"Sorted - Numeric array: {string.Join(",", array)}");
        }

        private static void SortedStringArr(string[] array)
        {
            Array.Sort(array);

            Console.WriteLine($"Original - String array: {string.Join(",", array)}");
            Console.WriteLine($"Sorted - String array: {string.Join(",", array)}");
        }

    }
}
