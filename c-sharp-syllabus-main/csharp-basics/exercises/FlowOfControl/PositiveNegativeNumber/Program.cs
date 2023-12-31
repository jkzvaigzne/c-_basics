using System;

namespace PositiveNegativeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number.");
            string input = Console.ReadLine();
         
            if(int.TryParse(input, out int num))
            {
                string result = (num > 0) ? "Number is positive" : ((num < 0) ? "Number is negative" : "Number is zero");
                Console.WriteLine(result);
            } 
            else
            {
                Console.WriteLine("Invalid input.");
            }

            Console.Read();
        }
    }
}
