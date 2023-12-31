namespace Exercise__4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int day = 1;
            string result = GetWeekDay(day);
            Console.WriteLine(result);

            Console.Read();
        }

       static string GetWeekDay(int day)
        {
            return day switch
            {
                0 => "Sunday",
                1 => "Monday",
                2 => "Tuesday",
                3 => "Wednesday",
                4 => "Thursday",
                5 => "Friday",
                6 => "Saturday",
                _ => "Not a valid day"
            };
        }
    }
}
