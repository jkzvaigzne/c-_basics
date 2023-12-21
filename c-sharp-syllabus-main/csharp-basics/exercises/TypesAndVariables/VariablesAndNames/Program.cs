using System;

namespace VariablesAndNames
{
    class Program
    {
        private static void Main(string[] args)
        {
            var cars = 100; 
            var seatsInACar = 4.0; 
            var drivers = 28; 
            var passengers = 90;

            var carsNotDriven = cars - drivers;
            var carsDriven = drivers;
            var carpoolCapacity = carsDriven * seatsInACar;
            var averagePassengersPerCar = passengers / carsDriven;

            Console.WriteLine("There are " + cars + " cars available.");
            Console.WriteLine("There are only " + drivers + " drivers available.");
            Console.WriteLine("There will be " + carsNotDriven + " empty cars today.");
            Console.WriteLine("We can transport " + carpoolCapacity + " people today.");
            Console.WriteLine("We have " + passengers + " to carpool today.");
            Console.WriteLine("We need to put about " + averagePassengersPerCar + " in each car.");
            Console.ReadKey();
        }
    }
}