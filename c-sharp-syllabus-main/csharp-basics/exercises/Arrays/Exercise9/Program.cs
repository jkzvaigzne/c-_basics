using System;

class Program
{
    static void Main()
    {
        string[][] testCase = {
            new string[] { "mavis", "senaida", "letty" },
            new string[] { "samuel", "MABELLE", "letitia", "meridith" },
            new string[] { "Slyvia", "Kristal", "Sharilyn", "Calista" }
        };

        foreach (string[] word in testCase)
        {
            string[] capitalizedWords = CapitalizeFirstWordLetters(word);
            PrintWords(capitalizedWords);
            Console.WriteLine();
        }

        Console.Read();
    }

    static string[] CapitalizeFirstWordLetters(string[] words)
    {
        return Array.ConvertAll(words, word =>
            string.IsNullOrEmpty(word) ? word : char.ToUpper(word[0]) + word.Substring(1).ToLower());  
    }

    static void PrintWords(string[] words)
    {
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }
}
