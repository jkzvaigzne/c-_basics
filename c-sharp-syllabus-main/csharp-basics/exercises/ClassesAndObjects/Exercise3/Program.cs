using System;

namespace Exercise3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var fuelGauge = new FuelGauge(GetValidInt("Enter fuel: "));
            var odometer = new Odometer(GetValidInt("Enter odometer stats: "), fuelGauge);

            while (true)
            {
                if (GetValidUserYesOrNo("Do you want to drive +10km? (y or n)") != 'y')
                    break;

                for (var i = 0; i < 10; i++)
                    odometer.IncrementMileage();

                Console.WriteLine($"Current mileage: {odometer.GetMileage()} Fuel: {fuelGauge.GetFuelAmount()}");

                if (fuelGauge.GetFuelAmount() <= 0)
                {
                    Console.WriteLine($"Your tank is empty and you travel {odometer.GetMileage()} km.");
                    break;
                }
            }

            Console.ReadLine();
        }

        private static int GetValidInt(string message)
        {
            int result;
            while (true)
            {
                Console.WriteLine(message);
                if (int.TryParse(Console.ReadLine(), out result) && result >= 0)
                    return result;
            }
        }

        private static char GetValidUserYesOrNo(string message)
        {
            char userChoice;
            Console.Write(message);
            while (true)
            {
                userChoice = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if (userChoice == 'y' || userChoice == 'n')
                    return userChoice;
            }
        }
    }
}
