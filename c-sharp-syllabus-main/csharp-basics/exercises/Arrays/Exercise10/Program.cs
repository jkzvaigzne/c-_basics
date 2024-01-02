using System;

namespace Exercise10
{
    internal class Program
    {

        static int CountPositiveValues(int[] array)
        {
            int result = 0;

            foreach (var item in array)
            {
                result += item > 0 ? 1 : 0;
            }
            Console.WriteLine($"There are a total of {result} positive numbers.");
            
            return result;
        }

        static int CountNegativeValues(int[] array)
        {
            int result = 0;

            foreach(int item in array)
            {
                result += item < 0 ? item : 0;
            }  
            Console.WriteLine($"The sum of all negative numbers equals {result}.");
           
            return result;
        }

        static int[] CountPositiveResNeg(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                Console.WriteLine("Array is empty");
                int[] result = new int[0];

                return result;
            }

            int positiveCount = CountPositiveValues(array);
            int negativeCount = CountNegativeValues(array);

            return new int[] { positiveCount, negativeCount };
        }

        static void PrintAndProceedArray(int[] array)
        {
            int[] result = CountPositiveResNeg(array);
            Console.WriteLine(string.Join(", ", result));
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] arrayFirst = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 };
            PrintAndProceedArray(arrayFirst);

            int[] arraySecond = { 92, 6, 73, -77, 81, -90, 99, 8, -85, 34 };
            PrintAndProceedArray(arraySecond);

            int[] arrayThird = { 91, -4, 80, -73, -28 };
            PrintAndProceedArray(arrayThird);

            int[] emptyArray = { };
            PrintAndProceedArray(emptyArray);

            Console.Read();
        }
    }
}
