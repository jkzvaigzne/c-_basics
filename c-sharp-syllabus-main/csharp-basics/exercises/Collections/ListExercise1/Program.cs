using System;
using System.Collections.Generic;


namespace ListExercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<string> colors = new List<string> { "Sandy Brown", "Medium Blue", "Pale Green", "Light Yellow", "Floral White" };

            foreach(string color in colors)
            {
                Console.WriteLine(color);
            }

            Console.Read();
        }
    }
}
