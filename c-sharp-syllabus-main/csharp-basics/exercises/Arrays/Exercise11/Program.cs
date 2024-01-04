using System;

namespace Exercise11
{
    internal class Program
    {
        static string FindWordPosition(string text, string targetWord)
        {
            char[] rullesOptions = { ' ', ',', '.', '?', '!' };
            string[] words = text.Split(rullesOptions);

            int index = Array.IndexOf(words, targetWord.Trim());
            return index >= 0 ? $"I found {targetWord} at {index + 1}" : $"I can't find {targetWord} :(";
        }

        static void OutputPatern(string[] texts, string targetWord)
        {
            foreach (string text in texts)
            {
                Console.WriteLine(FindWordPosition(text, targetWord));
            }
        }

        static void Main(string[] args)
        {
            string targetWord = "Nemo";
            string[] sentences = { $"I am finding {targetWord} !", $"{targetWord} is me", $"I {targetWord} am" };

            OutputPatern(sentences, targetWord);

            Console.Read();
        }
    }
}
