using System;

namespace GetTheCentury
{
    internal class Program
    {

        static string getTheCentury(int year)
        {
            int minYear = 1000;
            int maxYear = 2010;

            if (year < minYear || year > maxYear) 
                return "Please enter a year between 1000 to 2010.";
            
            int century = (year - 1) / 100 + 1;
            string prefix =
                   (century % 10 == 1 && century != 11) ? "st" :
                   (century % 10 == 2 && century != 12) ? "nd" :
                   (century % 10 == 3 && century != 13) ? "rd" : "th";

            return $"{year} is in the {century}{prefix} century";

        }

        static int getUserChoiceYear()
        {
            while(true)
            {
              Console.WriteLine("Enter a year to check century (1000 - 2010)");
                if (int.TryParse(Console.ReadLine(), out int year))
                {
                    if (year >= 1000 && year <= 2010)
                        return year;
                }
                Console.WriteLine("Please follow the rules. Enter a valid numeric year between 1000 to 2010");
            }
        }

        static bool checkAnotherYear()
        {
            Console.WriteLine("Do you want to check another year? (Y/N)");
            string choice = Console.ReadLine()?.Trim().ToUpper();
            return choice == "Y";
        }

        static void Main(string[] args)
        {
            bool close = false;
            while(!close)
            {
                int year = getUserChoiceYear();
                string output = getTheCentury(year);
                Console.WriteLine(output);
                close = !checkAnotherYear();
            }
        }
    }
}
