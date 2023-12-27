using System;

namespace CalculateArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = GetMenu();

            while (input != 4)
            {
                switch (input)
                {
                    case 1:
                        CalculateCircleArea();
                        break;
                    case 2:
                        CalculateRectangleArea();
                        break;
                    case 3: 
                        CalculateTriangleArea();
                        break;
                    default:
                        Console.WriteLine("Wrong selection!");
                        break;
                }

                input = GetMenu();
            }
        }

        public static int GetMenu()
        {
            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("Enter your choice (1-4) : ");

            int userChoice;
            bool isValidUserChoice = int.TryParse(Console.ReadLine(), out userChoice);

            if(!isValidUserChoice || userChoice < 1 || userChoice > 4)
            {
                Console.WriteLine("Invalid input. Please enter valid choice");
                userChoice = GetMenu();
            }

            return userChoice;
        }

        public static void CalculateCircleArea()
        {
            decimal radius = GetValidDecimal("What is the circle's radius? ");
            decimal area = Geometry.AreaOfCircle(radius);
            Console.WriteLine($"The circle's area is {area:F2}");
        }

        public static void CalculateRectangleArea()
        {
            decimal length = GetValidDecimal("Enter length? ");
            decimal width = GetValidDecimal("Enter width? ");
            Console.WriteLine("The rectangle's area is " + Geometry.AreaOfRectangle(length, width));

        }

        public static void CalculateTriangleArea()
        {
            decimal ground = GetValidDecimal("Enter length of the triangle's base? ");
            decimal heigth = GetValidDecimal("Enter triangle's heigth? ");

            Console.WriteLine("The triangle's area is " + Geometry.AreaOfTriangle(ground, heigth));
        }

        static decimal GetValidDecimal(string message)
        {
            decimal number;

            while(true)
            {
                Console.WriteLine(message);

                if (decimal.TryParse(Console.ReadLine(), out number) && number > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid positive decimal number.");
                }
            }

            return number;
        }
    }
}
