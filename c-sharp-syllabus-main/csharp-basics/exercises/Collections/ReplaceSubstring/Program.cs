using System;
using System.Linq;

namespace ReplaceSubstring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var words = new[] { "near", "speak", "tonight", "weapon", "customer", "deal", "lawyer" };

            foreach (var word in words)
            {
                string newWords = word.Contains("ea") ? word.Replace("ea", "*") : word;
                Console.WriteLine(newWords);
            }

            Console.Read();
        }
    }
}
