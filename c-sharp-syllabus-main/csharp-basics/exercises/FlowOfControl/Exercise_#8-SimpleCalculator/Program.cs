using System;

namespace Exercise__8_SimpleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator App");

            while (true)
            {
                Console.WriteLine("enter first number:");
                double userChoiceNumberOne;
                if (!double.TryParse(Console.ReadLine(), out userChoiceNumberOne))
                {
                    Console.WriteLine("invalid input. please enter valid number.");
                    continue;
                }

                Console.WriteLine("enter second number:");
                double userChoiceNumberTwo;
                if (!double.TryParse(Console.ReadLine(), out userChoiceNumberTwo))
                {
                    Console.WriteLine("invalid input. please enter valid number.");
                    continue;
                }

                Console.WriteLine("select operator (+, -, *, /):");
                char userOperator = Convert.ToChar(Console.ReadLine());

                double res = 0;

                switch (userOperator)
                {
                    case '+':
                        res = userChoiceNumberOne + userChoiceNumberTwo;
                        break;
                    case '-':
                        res = userChoiceNumberOne - userChoiceNumberTwo;
                        break;
                    case '*':
                        res = userChoiceNumberOne * userChoiceNumberTwo;
                        break;
                    case '/':
                        if (userChoiceNumberTwo != 0)
                        {
                            res = userChoiceNumberOne / userChoiceNumberTwo;
                        }
                        else
                        {
                            Console.WriteLine("division by zero not allowed.");
                            continue;
                        }
                        break;
                    default:
                        Console.WriteLine("invalid entered operator.");
                        continue;
                }

                Console.WriteLine($"Result: {userChoiceNumberOne} {userOperator} {userChoiceNumberTwo} = {res}");

                Console.WriteLine("Do you want to perform another calculation? (Y/N)");
                string playAgain = Console.ReadLine().Trim().ToUpper();

                if (playAgain != "Y")
                {
                    Console.WriteLine("Exiting the calculator.");
                    break;
                }
            }
        }
    }
}
