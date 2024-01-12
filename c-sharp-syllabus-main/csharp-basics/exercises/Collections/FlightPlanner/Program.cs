using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FlightPlanner
{
    class Program
    {
        private const string _path = "../../../flights.txt";
        private static Dictionary<string, Flight> _flights;
        private static string _userName;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your username:");
            _userName = Console.ReadLine().Trim();

            Console.WriteLine($"Welcome on board, {_userName.ToUpper()}. We are LufthansaX! The safest airline company in the world.");

            GetFlightsRoutes();
            UserOptions();

            char userChoice = Console.ReadKey().KeyChar;

            if (userChoice == '1')
            {
                Console.WriteLine();
                OutputCitiesList();
            }
            else
            {
                Environment.Exit(0);
            }

            Console.WriteLine($"{_userName}, select a city you would like to start and press 1");
            userChoice = Console.ReadKey().KeyChar;

            if (userChoice == '1')
            {
                PlanTravel();
            }
            else
            {
                Environment.Exit(0);
            }

            Console.ReadLine();
        }

        static void PlanTravel()
        {
            Queue<string> flightRoute = new Queue<string>();

            Console.WriteLine("...");
            string city = GetValidCity($"{_userName}, enter the name of the city you would like to start:");
            flightRoute.Enqueue(city);

            while (flightRoute.Count < 2 || flightRoute.Peek() != flightRoute.ToArray()[flightRoute.Count - 1])
            {
                Console.WriteLine($"Destinations from {city}: {string.Join(", ", _flights[city].DestinationCities)}");
                city = GetValidCity($"{_userName}, enter the name of the city you would like to visit next:");
                flightRoute.Enqueue(city);
            }

            Console.WriteLine($"Your route: " + string.Join(", ", flightRoute));
        }

        static void UserOptions()
        {
            Console.WriteLine($"So, {_userName}, what would you like to do? ");
            Console.WriteLine($"To display the list of cities press 1");
            Console.WriteLine($"To exit the program press #");
        }

        static string GetValidCity(string message)
        {
            while (true)
            {
                Console.WriteLine(message);
                string city = Console.ReadLine();

                if (_flights.ContainsKey(city))
                {
                    return city;
                }
                else
                {
                    Console.WriteLine($"The name {city} is not valid!");
                }
            }
        }

        static void GetFlightsRoutes()
        {
            _flights = new Dictionary<string, Flight>(StringComparer.OrdinalIgnoreCase);
            var readTxt = File.ReadAllLines(_path);

            foreach (var lines in readTxt)
            {
                if (lines != null)
                {
                    string[] flights = lines.Split("->").Select(city => city.Trim()).ToArray();

                    if (_flights.ContainsKey(flights[0]))
                    {
                        _flights[flights[0]].DestinationCities.Add(flights[1]);
                    }
                    else
                    {
                        _flights.Add(flights[0], new Flight(flights[0], new List<string> { flights[1] }));
                    }
                }
            }
        }

        static void OutputCitiesList()
        {
            Console.WriteLine(string.Join(" ", _flights.Keys));
        }
    }
}
