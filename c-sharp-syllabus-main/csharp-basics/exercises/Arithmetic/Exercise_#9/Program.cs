using System;

namespace Exercise_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BMI();
            Console.ReadKey();
        }

        static void BMI()
        {
            Console.WriteLine("Body Mass Index - Calculator");
            Console.WriteLine("Enter your body weight kilograms: ");
            double weight;

            if (!double.TryParse(Console.ReadLine(), out weight))
            {
                Console.WriteLine("Calculator accepts only numbers. Enter weight.");
                return;
            }

            Console.WriteLine("Enter your body height in meters: ");
            double height;

            if (!double.TryParse(Console.ReadLine(), out height))
            {
                Console.WriteLine("Calculator accepts only numbers. Enter height.");
                return;
            }

            double bmi = Calc(weight, height);
            Console.WriteLine($"Your BMI is: {bmi:F2}");

            string result = Check(bmi);
            Console.WriteLine($"You are {result}");
        }

        static double Calc(double weight, double height)
        {
            return weight / (height * height);
        }

        static string Check(double bodyMassIndex)
        {
            return bodyMassIndex < 18.5 ? "underweight" : (bodyMassIndex >= 18.5 && bodyMassIndex <= 25) ? "optimal weight" : "overweight";
        }
    }
}
