using System;

namespace Exercise14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTimeExtension.WeekdayInDutch(1970, 9, 21)); 
            Console.WriteLine(DateTimeExtension.WeekdayInDutch(1945, 9, 2));  
            Console.WriteLine(DateTimeExtension.WeekdayInDutch(2001, 9, 11));

            Console.Read();
        }
    }
}
