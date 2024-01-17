using System;
using System.IO;

namespace WordCount
{
    class Program
    {
        static void Main()
        {
            try
            {
                var filePathDir = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, "lear.txt");

                int lines = 0;
                int words = 0;
                int chars = 0;

                var fileContent = File.ReadLines(filePathDir);

                foreach (var line in fileContent)
                {
                    lines++;
                    words += line.Split(new char[] { ' ', '\t', '\'' }, StringSplitOptions.RemoveEmptyEntries).Length;
                    chars += line.Length;
                }

                Console.Write($"Lines = {lines}\nWords = {words}\nChars = {chars}");
            }
            catch (Exception ex)
            {
                Console.Write($"Error: {ex.Message}");
            }

            Console.Read();
        }
    }
}
