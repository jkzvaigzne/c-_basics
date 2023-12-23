namespace Exercise__4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = CalculateProduct(1, 10);
            Console.WriteLine("Rezultātu summa no: 1×2×3×4x5x6x7x8x9x10");
            Console.WriteLine($"Summa ir: {result}");
            Console.Read();
        }

        static int CalculateProduct(int start, int end) 
        {
            int productBase = 1;

            for(int i = start; i <= end; i++)
            {
                productBase *= i;
            }

            return productBase;
        }
    }
}
