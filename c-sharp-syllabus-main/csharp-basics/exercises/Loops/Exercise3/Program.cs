using System;

namespace Exercise3
{
    class Program
    {
        const int arraySize = 20;
        const int minRdmnNumber = 1;
        const int maxRdmnNumber = 100;

        static void Main(string[] args)
        {
            int[] numbers = RandomNumGenerate();
            int position = GetUserInputPos();
            int numberAtPosition = GetNumPos(numbers, position);

            DisplayPosition(position, numberAtPosition);
            Console.Read();
        }

        static int[] RandomNumGenerate()
        {
            Random random = new Random();
            int[] num = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                num[i] = random.Next(minRdmnNumber, maxRdmnNumber + 1);
            }

            return num;
        }

        static int GetUserInputPos()
        {
            Console.WriteLine($"Enter number position (1 - {arraySize}):");
            int position;

            while (!int.TryParse(Console.ReadLine(), out position) || position < 1 || position > arraySize)
            {
                Console.WriteLine($"Invalid input : Please enter number (1 - {arraySize})");
            }

            return position;
        }

        static int GetNumPos(int[] numbers, int position)
        {
            return numbers[position - 1];
        }

        static void DisplayPosition(int position, int numberAtPosition)
        {
            Console.WriteLine($"Number at position {position} is: {numberAtPosition}");
        }
    }
}
