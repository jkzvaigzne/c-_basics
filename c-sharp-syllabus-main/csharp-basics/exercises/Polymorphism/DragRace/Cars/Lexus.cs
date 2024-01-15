using System;

namespace DragRace.Cars
{
    public class Lexus : ICar
    {
        private const int GasPedal = 9;
        private const int BrakePedal = 12;
        private const int NitroOxideEngine = 15;
        private int _currentSpeed = 0;

        public void SpeedUp() => _currentSpeed += GasPedal;

        public void SlowDown() => _currentSpeed -= BrakePedal;

        public string ShowCurrentSpeed() => _currentSpeed.ToString();

        public void UseNitrousOxideEngine() => _currentSpeed += NitroOxideEngine;
     
        public void StartEngine() => Console.WriteLine("Rrrrrrr.....");
    }
}