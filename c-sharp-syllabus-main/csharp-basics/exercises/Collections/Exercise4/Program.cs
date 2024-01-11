using System;
using System.Collections.Generic;

namespace Exercise4
{
    internal class Program
    {
        static void Main()
        {
            var userChoiceNames = new HashSet<string>();

            while (ReadUserNames(userChoiceNames)) { }

            Console.Write("\n");
            Console.WriteLine($"unique name list of names: {string.Join(",", userChoiceNames)}");
            
            Console.Read();
        }

        static bool ReadUserNames(HashSet<string> names)
        {
            Console.Write("enter name:");
            string userChoice = Console.ReadLine()?.Trim().ToString();

            return string.IsNullOrWhiteSpace(userChoice) ? false : names.Add(userChoice);
        }
    }
}
