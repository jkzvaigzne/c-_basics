using System;

namespace Exercise__7_RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] choices = { "rock", "paper", "scissors" };

            Console.WriteLine("Rock, paper, scissors game!");
            PlayGame(choices);

            Console.WriteLine("Good bye!");
            Console.ReadLine();
        }

        static void PlayGame(string[] choices)
        {
            bool playAgain = true;

            while (playAgain)
            {
                Console.WriteLine("Select your choice: rock, paper, or scissors");
                string userChoice = Console.ReadLine()?.Trim().ToLower();

                if (Array.IndexOf(choices, userChoice) == -1)
                {
                    Console.WriteLine("invalid choice. please select rock, paper, or scissors");
                    continue;
                }

                string computerChoice = ComputerChoice(choices);
                Console.WriteLine($"Computer chose: {computerChoice}");

                string result = WinnerIs(userChoice, computerChoice);
                Console.WriteLine($"Result: {result}");

                playAgain = PlayAgain();
            }
        }

        static string ComputerChoice(string[] select)
        {
            Random random = new Random();
            return select[random.Next(0, 3)];
        }

        static string WinnerIs(string userChoice, string computerChoice)
        {
            return userChoice == computerChoice ? "it's a tie!" :
                (userChoice == "rock" && computerChoice == "scissors") ||
                (userChoice == "paper" && computerChoice == "rock") ||
                (userChoice == "scissors" && computerChoice == "paper") ? "user wins!" : "computer wins!";
        }

        static bool PlayAgain()
        {
            Console.WriteLine("Do you want to play another game? (Y/N)");
            string response = Console.ReadLine()?.Trim().ToLower();
            return response == "y";
        }
    }
}
