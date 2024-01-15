using System;

namespace DragRace
{
   public interface ICar
    {
        void SpeedUp();

        void SlowDown();

        void StartEngine();

        string ShowCurrentSpeed();
    }
}