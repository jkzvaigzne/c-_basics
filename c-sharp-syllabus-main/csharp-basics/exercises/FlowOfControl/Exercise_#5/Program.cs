using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercise__5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter text to convert in keypad digits: ");
            string input = Console.ReadLine();
            string sequence = ConvertKeypad(input);
            Console.WriteLine(sequence);

            Console.Read();
        }

        static string ConvertKeypad(string input)
        {
            string sentence = "";

            foreach(char currChar in input.ToLower())
            {
                int userDigit = 1;

                userDigit = currChar switch
                {
                    'a' or 'b' or 'c' => 2,
                    'd' or 'e' or 'f' => 3,
                    'g' or 'h' or 'i' => 4,
                    'j' or 'k' or 'l' => 5,
                    'm' or 'n' or 'o' => 6,
                    'p' or 'q' or 'r' or 's' => 7,
                    't' or 'u' or 'v' => 8,
                    'w' or 'x' or 'y' or 'z' => 9,
                    _ => 1 
                };

                if(userDigit != 1)
                {
                    sentence += userDigit;
                }
                else
                {
                    sentence += currChar;
                }
            }

            return sentence;
        }
    }
}

