using System;
using System.Collections.Generic;
using System.Text;

namespace MakeSounds
{
    public class Parot : ISound
    {
        public void PlaySound()
        {
            Console.WriteLine("Double or nothing");
        }
    }
}