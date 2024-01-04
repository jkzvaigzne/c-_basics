namespace Exercise6
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] firstArray = new int[10];
            int[] secondArray = new int[10];

            RandomFillArray(firstArray, secondArray);
            ChangeArrayLastValue(firstArray);

            OutputArray("first array", firstArray);
            OutputArray("second array", secondArray);

            Console.Read();
        }

        private static void RandomFillArray(int[] firstArray, int[] secondArray)
        {
            Random rndm = new Random();

            int minNumber = 1;
            int maxNumber = 101;

            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = secondArray[i] = rndm.Next(minNumber, maxNumber);
            }
        }

        private static void ChangeArrayLastValue(int[] array)
        {
            array[array.Length - 1] = -7;
        }

        private static void OutputArray(string sentence, int[] array)
        {
            Console.WriteLine($"{sentence} : {string.Join(" ", array)}");
        }
    }
}
