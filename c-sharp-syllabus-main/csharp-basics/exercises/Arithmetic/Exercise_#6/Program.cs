namespace Exercise__6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CozaLozaWoza();
            Console.Read();
        }

        static void CozaLozaWoza()
        {
            int smallestNum = 1;
            int biggestNum = 110;
            int numInLine = 11;

            for(int i = smallestNum; i <= biggestNum; i++)
            {
                string result =
                    (i % 3 == 0) ? "Coza" :
                    (i % 5 == 0) ? "Loza" :
                    (i % 7 == 0) ? "Woza" : i.ToString();
                
            Console.WriteLine(result + " ");

                if(i % numInLine == 0)
                {
                    Console.WriteLine();
                }
            }

        }
    }
}
