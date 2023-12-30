using System;

namespace Exercise5
{
    class Program
    {
        private static int searchElement(int[] array, int elementToFind)
        {
            return Array.IndexOf(array, elementToFind);
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Looking for specific index in array");

            int[] numbersArray = { 25, 14, 56, 15, 36, 56, 77, 18, 29, 49 };

            Console.WriteLine(string.Join(" ", numbersArray));

            int[] elementToFind = { 36, 29 };

            foreach (int el in elementToFind)
            {
                int indexOfEl = searchElement(numbersArray, el);
                
                Console.WriteLine($"Index of {el} is : {indexOfEl}");
            }

            Console.Read();
        }
    }
}
