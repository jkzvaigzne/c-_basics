using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Two digits after decimal point means "F2" format string.
            string name = "Zed A. Shaw";
            int age = 35;
            int heightInInches = 74;
            int weightInPounds = 180; 
            string eyes = "blue";
            string teeth = "white";
            string hair = "brown";

            double inchesToCm = 2.54;
            double poundsToKg = 0.453592;

            double heigthInCm = heightInInches * inchesToCm;
            double weigthInKg = weightInPounds * poundsToKg;

            Console.WriteLine("Let's talk about " + name + ".");
            Console.WriteLine("He's " + heigthInCm.ToString("F2") + " inches tall.");
            Console.WriteLine("He's " + weigthInKg.ToString("F2") + " pounds heavy.");
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine("He's got " + eyes + " eyes and " + hair + " hair.");
            Console.WriteLine("His teeth are usually " + teeth + " depending on the coffee.");

            Console.WriteLine("If I add " + age + ", " + heightInInches + ", and " + weightInPounds
                               + " I get " + (age + heightInInches + weightInPounds) + ".");

            Console.ReadKey();
        }
    }
}