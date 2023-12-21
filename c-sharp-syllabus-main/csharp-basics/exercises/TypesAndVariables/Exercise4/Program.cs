namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Jēkabs";
            int yearOfBirth = 1995;

            Console.WriteLine("My name is " + name + " and I was born in " + yearOfBirth + ".");
            Console.Write($"My name is {name} and I was born in {yearOfBirth}.");

            Console.ReadKey();
        }
    }
}
