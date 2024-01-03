using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            printVowelsForLoop(vowels);
            Console.WriteLine();
            printVowelsForeachLoop(vowels);

            Console.Read();
        }

        static void printVowelsForLoop(char[] vowels)
        {
            for(int i = 0; i < vowels.Length; i++)
            {
                Console.WriteLine(vowels[i]);
            }
        }

        static void printVowelsForeachLoop(char[] vowels)
        {
            foreach(char character in vowels)
            {
                Console.WriteLine(character);
            }
        }
    }
}
