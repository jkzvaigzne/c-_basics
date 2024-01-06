using System;

namespace FuelConsumptionCalculator
{
    class Program
    {
        static void Main()
        {
            Car userFirstCar = new Car(GetValidUserDouble("Enter start odometer number: "));

            bool isRefueled = false;
            int userFirstMileage = 0;

            while (true)
            {
                if (isRefueled && (userFirstCar.IsEconomyCar() || userFirstCar.IsGasHog()))
                {
                    Console.WriteLine(userFirstCar.IsEconomyCar() ? "This is an economy car!" : "This is a gas hog car!");
                }

                if (GetValidUserYesOrNo("Fill up? (y or n)") != 'y')
                {
                    break;
                }

                userFirstMileage = GetValidUserMileage("Enter mileage: (Mileage is the current odometer reading)", userFirstMileage);
                double userFirstLiters = GetValidUserDouble("Liters: ");

                userFirstCar.FillUp(userFirstMileage, userFirstLiters);
                Console.WriteLine($"Consumption: {userFirstCar.CalculateConsumptions():F2}\nOdometer reading: {userFirstCar.EndKilometers}");

                isRefueled = true;
            }

            Console.ReadLine();
        }

        static double GetValidUserDouble(string message, double min = 0.0)
        {
            double result;

            do
            {
                Console.WriteLine(message);
            } while (!double.TryParse(Console.ReadLine(), out result) || result < min);

            return result;
        }

        static int GetValidUserMileage(string message, int min)
        {
            int result;

            do
            {
                Console.WriteLine(message);
            } while (!int.TryParse(Console.ReadLine(), out result) || result <= min);

            return result;
        }

        static char GetValidUserYesOrNo(string message)
        {
            char userChoice;

            do
            {
                Console.Write(message);
                userChoice = Console.ReadKey().KeyChar;
                Console.WriteLine();
            } while (userChoice != 'y' && userChoice != 'n');

            return userChoice;
        }
    }
}
