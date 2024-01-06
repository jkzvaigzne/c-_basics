using System;

class NumberSquare
{
    static void Main()
    {
        int minValue;
        int maxValue;

        Console.Write("Min Value?");
        while (!int.TryParse(Console.ReadLine(), out minValue))
        {
            Console.WriteLine("Please enter valid number: ");
        }

        Console.Write("Max Value?");
        while (!int.TryParse(Console.ReadLine(), out maxValue))
        {
            Console.WriteLine("Please enter valid number: ");
        }

        for (int i = 0; i < maxValue - minValue + 1; i++)
        {
            for (int j = 0; j < maxValue - minValue + 1; j++)
                Console.Write((minValue + (i + j) % (maxValue - minValue + 1)));

            Console.WriteLine(minValue + i);
        }

        Console.ReadLine();
    }
}
