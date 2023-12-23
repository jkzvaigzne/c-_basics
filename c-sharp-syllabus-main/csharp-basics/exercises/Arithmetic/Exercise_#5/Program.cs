using System;

namespace Exercise__5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RandomNumberToHundred();
            Console.Read();
        }

        static void RandomNumberToHundred()
        {
            Random random = new Random();
            int userAttempts = 10;
            int prize = 50;
            int generatedRandomNumber = random.Next(1, 101);
            Console.WriteLine($"Es domāju par skaitli no 1-100. Vai spēsi to uzminēt ar {userAttempts} meiģinājumiem?");

            for (int userAttempt = 1; userAttempt <= userAttempts; userAttempt++)
            {
                Console.WriteLine($"Atlikušie meiģinājumi: {userAttempt}-{userAttempts}");
                string userChoice = Console.ReadLine();

                if (int.TryParse(userChoice, out int userGuess))
                {
                    if (userGuess == generatedRandomNumber)
                    {
                        Console.WriteLine($"Apsveicu, tu uzminēji manu skaitli: {generatedRandomNumber}. Tu laimēji {prize} punktus.");
                        break;
                    }
                    else if (userGuess < generatedRandomNumber)
                    {
                        Console.WriteLine($"Atvaino, tu mini par zemu.");
                    }
                    else
                    {
                        Console.WriteLine("Atvaino, tu mini par augstu.");
                    }
                }
                else
                {
                    Console.WriteLine("Lūdzu, ievadi derīgu skaitli no 1 līdz 100.");
                }

                if (userAttempt == userAttempts)
                {
                    Console.WriteLine($"Tev diemžēl beidzās meiģinājumi. Es domāju par skaitli: {generatedRandomNumber}.");
                }
            }
        }
    }
}
