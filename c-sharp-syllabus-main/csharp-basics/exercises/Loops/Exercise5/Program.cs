namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first word:");
            string firstUserInput = Console.ReadLine();

            Console.WriteLine("Enter second word:");
            string secondUserInput = Console.ReadLine();

            DisplayWordsAndDots(firstUserInput, secondUserInput);

            Console.Read();
        }

        static void DisplayWordsAndDots(string firstWord, string secondWord)
        {
            int lineHeigth = 30;
            int countDots = lineHeigth - (firstWord.Length + secondWord.Length);

            Console.WriteLine(firstWord);
            
            printDots(countDots);

            Console.WriteLine(secondWord);
        }

        static void printDots(int counter)
        {
            for(int i = 0; i < counter; i++)
            {
                Console.WriteLine(".");
            }
        }
    }
}
