using System;

namespace DragRace.Cars
{
    public class Bmw : ICar
    {
        private const int GasPedal = 12;
        private const int BrakePedal = 13;
        private int _currentSpeed = 0;

        public void SpeedUp() => _currentSpeed += GasPedal;

        public void SlowDown() => _currentSpeed -= BrakePedal;

        public string ShowCurrentSpeed() => _currentSpeed.ToString();

        public void StartEngine() => Console.WriteLine("Rrrrrrr.....");
    }
}