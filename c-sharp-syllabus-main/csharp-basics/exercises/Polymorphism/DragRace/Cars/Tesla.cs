using System;

namespace DragRace.Cars
{
    public class Tesla : ICar
    {
        private const int SpeedUpIncrement = 15;
        private const int SlowDownDecrement = 12;
        private int _currentSpeed = 0;

        public void SpeedUp() => _currentSpeed += SpeedUpIncrement;

        public void SlowDown() => _currentSpeed -= SlowDownDecrement;

        public string ShowCurrentSpeed() => _currentSpeed.ToString();

        public void StartEngine() => Console.WriteLine("-- silence --");
    }
}