using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercise__5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some text: ");
            string userText = Console.ReadLine().ToLower();

            Console.WriteLine("Keypad sequence output: ");
            string keypad = CovertKeypad(userText);
            Console.WriteLine(keypad);

            Console.Read();
        }

        static string CovertKeypad(string input)
        {
            string sequence = "";

            foreach(char currentChar in input)
            {
                int userDigit = 1;

                switch(currentChar)
                {
                    case 'a':
                    case 'b':
                    case 'c':
                        userDigit = 2;
                        break;
                    case 'd':
                    case 'e':
                    case 'f':
                        userDigit = 3;
                        break;
                    case 'j':
                    case 'k':
                    case 'l':
                        userDigit = 5;
                        break;
                    case 'm':
                    case 'n':
                    case 'o':
                        userDigit = 6;
                        break;
                    case 'p':
                    case 'q':
                    case 'r':
                    case 's':
                        userDigit = 7;
                        break;
                    case 't':
                    case 'u':
                    case 'v':
                        userDigit = 8;
                        break;
                    case 'w':
                    case 'x':
                    case 'y':
                    case 'z':
                        userDigit = 9;
                        break;
                }

                if(userDigit != 1)
                {
                    sequence += userDigit;
                } 
                else
                {
                    sequence += currentChar;
                }
            }

            return sequence;
        }
    }
}

