using System;

namespace DragRace.Cars
{
    public class Cybertruck : ICar, IBoostable
    {
        private const int GasPedal = 25;
        private const int BrakePedal = 19;
        private const int NitroOxideEngine = 45;
        private int _currentSpeed = 0;

        public void SpeedUp() => _currentSpeed += GasPedal;

        public void SlowDown() => _currentSpeed -= BrakePedal;

        public string ShowCurrentSpeed()=> _currentSpeed.ToString();

        public void UseNitrousOxideEngine() => _currentSpeed += NitroOxideEngine;

        public void StartEngine() => Console.WriteLine("-- generated AI voice greet owner and start engine in silence --");

    }
}