using System;
using System.Collections.Generic;
using System.Linq;

namespace UniqueValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var values = new List<string> { "Hi", "Meow", "Hello", "Meow", "Hi!", "Meow", "Hi", "Bye" };

            var uniqueValues = values.GroupBy(a => a)
                                    .Where(b => b
                                    .Count() == 1)
                                    .Select(c => c.Key);

            foreach (var uniqueValue in uniqueValues)
            {
                Console.WriteLine($"unique value: {uniqueValue}");
            }

            Console.Read();
        }
    }
}
