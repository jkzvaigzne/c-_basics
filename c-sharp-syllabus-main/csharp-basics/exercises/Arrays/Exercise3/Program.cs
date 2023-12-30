using System;

namespace Exercise3
{
    class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = {20, 30, 25, 35, -16, 60, -100};

            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            double avg = (double)sum / numbers.Length;

            Console.WriteLine($"Sum of array elements is: {sum}" );
            Console.WriteLine($"Average value of the array elements is : {avg}");
            
            Console.Read();
        }
    }
}
