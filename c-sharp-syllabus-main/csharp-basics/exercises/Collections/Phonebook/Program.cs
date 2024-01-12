using System;
using PhoneBook;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneDirectory phoneDirectory = new PhoneDirectory();

            phoneDirectory.PutNumber("John Doe", "371-288-888-88");

            Console.WriteLine($"John Doe: {phoneDirectory.GetNumber("John Doe")}");

            Console.Read();
        }
    }
}
