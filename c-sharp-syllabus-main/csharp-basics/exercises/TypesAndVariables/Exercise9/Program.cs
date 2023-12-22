using System;

namespace Exercise9
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Ievadi distanci metros:");
            double distanceMeters = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ievadi laiku stundās:");
            int hours = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ievadi laiku minutēs:");
            int minutes = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ievadi laiku sekundēs:");
            int seconds = Convert.ToInt32(Console.ReadLine());

            int totalTimeInSeconds = hours * 3600 + minutes * 60 + seconds;

            double speedMetersPerSecond = distanceMeters / totalTimeInSeconds;
            double speedKilometersPerHour = (distanceMeters / 1000) / (totalTimeInSeconds / 3600.0);
            double speedMilesPerHour = (distanceMeters / 1609) / (totalTimeInSeconds / 3600.0);

            Console.WriteLine($"Speed: {speedMetersPerSecond:F2} m/s");
            Console.WriteLine($"Speed: {speedKilometersPerHour:F2} km/h");
            Console.WriteLine($"Speed: {speedMilesPerHour:F2} mph");

            Console.Read();
        }
    }
}