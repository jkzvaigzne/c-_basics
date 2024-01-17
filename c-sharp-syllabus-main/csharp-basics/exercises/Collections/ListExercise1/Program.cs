using System;
using System.Collections.Generic;


namespace ListExercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<string> colors = new List<string>();

            colors.Add("Sandy Brown");
            colors.Add("Medium Blue");
            colors.Add("Pale Green");
            colors.Add("Light Yellow");
            colors.Add("Floral White");

            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }

            Console.Read();
        }
    }
}

