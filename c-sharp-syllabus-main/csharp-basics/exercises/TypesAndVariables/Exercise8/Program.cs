using System;

namespace Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter minutes");
            var minutes = int.Parse(Console.ReadLine());

            var daysInYearFullYear = 365;
            
            var hoursInDay = 24;
            var minutesInHour = 60;
           

            var minutesInYear = daysInYearFullYear * hoursInDay * minutesInHour;
            var minutesInDay = hoursInDay * minutesInHour;

            var years = minutes / minutesInYear;
            var minutesToDays = minutes % minutesInYear;
            var days = minutesToDays / minutesInDay;
            
            Console.WriteLine($"it's {years} years and {days} days");

            Console.ReadKey();
        }
    }
}
