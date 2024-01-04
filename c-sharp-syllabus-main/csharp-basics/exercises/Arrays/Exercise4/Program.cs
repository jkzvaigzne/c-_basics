using System;

namespace Exercise4
{
    class Program
    {
        private static void Main(string[] args)
        {
            int[] yearsArray =
            {
                1789, 2035, 1899, 1456, 2013,
                1458, 2458, 1254, 1472, 2365,
                1456, 2265, 1457, 2456
            };

            int matchingValue = 1789;

            bool value = Array.Exists(yearsArray, element => element == matchingValue);

            string output = value ?
                "Array contains value : " + matchingValue :
                "Array does not contain value: " + matchingValue;

            Console.WriteLine(output);
            Console.Read();
        }
    }
}
