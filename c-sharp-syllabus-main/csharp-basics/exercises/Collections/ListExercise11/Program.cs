using System;
using System.Collections.Generic;


namespace ListExercise11
{
    class Program
    {
        const int TotalValues = 10;
        const int Position = 4;
        const int LastIndex = -1;

        static void Main(string[] args)
        {
            List<string> stringList = new List<string>();

            for (int i = 1; i <= TotalValues; i++)
            {
                stringList.Add($"value {i}");
            }

            stringList.Insert(Position, "new value");

            int lastIndex = stringList.Count + LastIndex;
            stringList[lastIndex] = "changed";

            stringList.Sort();

            bool containsFoobar = stringList.Contains("foobar");

            foreach (var el in stringList)
            {
                Console.Write(el + " ");
            }

            Console.WriteLine();

            Console.WriteLine($"list contains 'foobar': {containsFoobar}");

            Console.Read();
        }
    }
}
