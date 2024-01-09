using System;
using System.Collections.Generic;

namespace ListExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            var colors = new List<string>();
            colors.Add("Red");
            colors.Add("Green");
            colors.Add("Orange");
            colors.Add("White");
            colors.Add("Black");

            colors.Insert(0, "Forest Green");
            Console.WriteLine(string.Join(",", colors));

            colors.Insert(0, "Light Coral");
            colors.Insert(2, "Blue Violet");
            Console.WriteLine(string.Join(",", colors));

            Console.Read();
        }
    }
}
