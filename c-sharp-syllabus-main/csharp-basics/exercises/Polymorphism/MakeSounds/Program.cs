using System;
using System.Collections.Generic;

namespace MakeSounds
{
    class Program
    {
        private static void Main(string[] args)
        {
            List<ISound> sounds = new List<ISound> { new Parot(), new Firework(), new Radio() };

            sounds.ForEach(sound => sound.PlaySound());

            Console.Read();
        }
    }
}