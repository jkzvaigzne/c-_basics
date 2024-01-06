namespace Exercise7
{
    internal class Program
    {
        private const int minNumber = 1;
        private const int maxNumber = 6;
        private const int loseRoll = 1;
        private const string gameName = "PIGLET";
        static void Main(string[] args)
        {
            Console.WriteLine($"Welcome to {gameName} game");

            Console.WriteLine("Enter your username: ");
            string username = Console.ReadLine().ToLower().ToString();

            int totalPt = 0;
            bool continueRolls = true;

            while(continueRolls)
            {
                int roll = RollDiec();
                Console.WriteLine($"{username} rolled a {roll}.");

                totalPt = CalculatePt(roll, totalPt);
                continueRolls = TryRollAgain(roll);
            }

            Console.WriteLine($"Congratulations: {username} got {totalPt} points.");
            Console.Read();
        }

        static int RollDiec()
        {
            Random random = new Random();
            return random.Next(minNumber, maxNumber + 1);
        }

        static int CalculatePt(int roll, int totalPt)
        {
            return (roll == loseRoll) ? 0 : totalPt + roll;
        }

        static bool TryRollAgain(int roll)
        {
            Console.WriteLine("Play again?");
            return (Console.ReadLine().ToLower() == "y" && roll != loseRoll);
        }
    }
}
