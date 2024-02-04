using System;
using System.Collections.Generic;
using DragRace;
using DragRace.Cars;

namespace DragRace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ICar> cars = InitializeCars();
            RaceCars(cars);
            ShowWinner(cars);
            Console.Read();
        }

        private static List<ICar> InitializeCars() => new List<ICar> { new Bmw(), new Cybertruck(), new Porsche911(), new Audi(), new Tesla(), new Lexus(), };

        private static void RaceCars(List<ICar> cars)
        {
            const int raceIterator = 10;
            const int engineStart = 0;
            const int boostIterator = 2;

            for (int i = 0; i < raceIterator; i++)
            {
                foreach (var car in cars)
                {
                    switch (i)
                    {
                        case var _ when i == engineStart:
                            car.StartEngine();
                            continue;
                        case var _ when i == boostIterator && car is IBoostable boostableCar:
                            boostableCar.UseNitrousOxideEngine();
                            continue;
                        default:
                            car.SpeedUp();
                            continue;
                    }
                }

            }
        }


        static void ShowWinner(List<ICar> cars)
        {
            int carMaxSpeed = 0;
            string fastestCar = null;

            foreach (var car in cars)
            {
                int currentSpeed = int.Parse(car.ShowCurrentSpeed());

                if (currentSpeed > carMaxSpeed)
                {
                    carMaxSpeed = currentSpeed;
                    fastestCar = car.GetType().Name;
                }
            }

            Console.WriteLine($"Fastest: {fastestCar}");
            Console.WriteLine($"Speed: {carMaxSpeed}");
        }
    }
}
