using System;

namespace LargestNumber
{
    class Program
    {

        static int FindLargestNumber(int numberOne, int numberTwo, int numberThree)
        {
            return (numberOne > numberTwo) ? ((numberOne > numberThree) ? numberOne : numberThree) : ((numberTwo > numberThree) ? numberTwo : numberThree);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input the 1st number: ");
            var firstUserInput = Console.ReadLine();
            int numberOne = Convert.ToInt32(firstUserInput);

            Console.WriteLine("Input the 2nd number: ");
            var secondUserInput = Console.ReadLine();
            int numberTwo = Convert.ToInt32(secondUserInput);

            Console.WriteLine("Input the 3rd number: ");
            var thirdUserInput = Console.ReadLine();
            int numberThree = Convert.ToInt32(thirdUserInput);

            Console.WriteLine($"Input the 1st number: {numberOne}");
            Console.WriteLine($"Input the 2nd number: {numberTwo}");
            Console.WriteLine($"Input the 3rd number: {numberThree}");

            int largestNum = FindLargestNumber(numberOne, numberTwo, numberThree);
            Console.WriteLine($"Largest number is {largestNum}");

            Console.Read();
        }
    }
}
