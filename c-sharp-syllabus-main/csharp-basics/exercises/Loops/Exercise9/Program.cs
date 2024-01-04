using System;

class RollTwoDice
{
    static void Main()
    {
        Console.WriteLine("Desired sum");

        Random random = new Random();

        int sum;
        do
        {
            Console.Write("Enter number: ");
        } while (!int.TryParse(Console.ReadLine(), out sum));

        RollDie(random, sum);

        Console.ReadLine();
    }

    static void RollDie(Random random, int desiredSum)
    {
        while (true)
        {
            int rollOne = random.Next(1, 6) + 1;
            int rollTwo = random.Next(1, 6) + 1;
            int result = rollOne + rollTwo;

            Console.WriteLine($"{rollOne} and {rollTwo} = {result}");

            if (result == desiredSum)
            {
                break;
            }
        }
    }
}
