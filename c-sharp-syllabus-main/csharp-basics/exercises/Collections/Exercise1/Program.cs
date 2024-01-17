using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise1
{
    class Program
    {

        static string GetCountries(string car) =>
                  car switch
                  {
                      "Audi" or "BMW" or "Mercedes" or "VolksWagen" => "Germany",
                      "Honda" => "Japan",
                      "Tesla" => "USA",
                      _ => "Earth"
                  };

        private static void Main(string[] args)
        {
            List<string> carBrandsList = new List<string> { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };

            foreach (string carBrand in carBrandsList)
            {
                Console.WriteLine($"{carBrand}-{GetCountries(carBrand)}");
            }

            Console.Write("\n");

            HashSet<string> carHashSet = new HashSet<string>(carBrandsList);

            foreach (var car in carHashSet)
            {
                Console.WriteLine($"{car}-{GetCountries(car)}");
            }

            Console.Write("\n");

            Dictionary<string, string> carOriginsDict = new Dictionary<string, string>
            {
                { "Audi", "Germany" },
                { "BMW", "Germany" },
                { "Mercedes", "Germany" },
                { "VolksWagen", "Germany" },
                { "Honda", "Japan" },
                { "Tesla", "USA" }
            };

            foreach (var kvp in carOriginsDict)
            {
                Console.WriteLine($"{kvp.Key}-{kvp.Value}");
            }

            Console.Read();
        }
    }
}
