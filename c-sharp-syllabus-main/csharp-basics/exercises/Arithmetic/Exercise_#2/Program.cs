namespace Exercise__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pāris vai nepāris");
            Console.WriteLine("Ievadi ciparu:");

            int userNumber;

            while(!int.TryParse(Console.ReadLine(), out userNumber))
            {
                Console.WriteLine("To ko? Programma pieņem tikai skaitļus!");
            }

            string result = (userNumber % 2 == 0) ? "Tu ievadīji pāra skaitli" : "Tu ievadīji nepāra skaitli";
            Console.WriteLine(result);

            Console.WriteLine("Bye!");
            Console.Read();
        }
    }
}
