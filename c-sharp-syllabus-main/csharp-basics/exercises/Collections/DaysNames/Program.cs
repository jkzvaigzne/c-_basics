using System;

namespace DaysNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] weekDays = Enum.GetNames(typeof(DayOfWeek)).ToArray();

            Console.WriteLine("days:\n" + string.Join("\n", weekDays));

            Console.Read();
        }
    }
}
