namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product logitechMouse = new Product("Logitech mouse", 70.00, 14);
            Product iPhone = new Product("iPhone 5s", 999.99, 3);
            Product epson = new Product("Epson EB-U05", 440.46, 1);

            logitechMouse.OutputProductDetails();
            iPhone.OutputProductDetails();
            epson.OutputProductDetails();

            Console.WriteLine();

            logitechMouse.UpdateProductPrice(49.99);
            logitechMouse.OutputProductDetails();

            iPhone.SubtractProductAmountByOne();
            iPhone.OutputProductDetails();

            epson.AddAmountToProduct();
            epson.OutputProductDetails();

            Console.ReadLine();
        }
    }
}
