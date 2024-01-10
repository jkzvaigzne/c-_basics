namespace Exercise1
{
    public class Product
    {
        public string Name { get; private set; }
        public double Price { get; private set; }
        public int Amount { get; private set; }

        public Product(string name, double priceAtStart, int amountAtStart)
        {
            Name = name;
            Price = priceAtStart;
            Amount = amountAtStart;
        }

        public void OutputProductDetails() => Console.WriteLine($"{Name}, price {Price}, amount {Amount}");

        public void AddAmountToProduct() => Amount++;

        public void SubtractProductAmountByOne()
        {
            const int minAmount = 0;

            if(Amount > minAmount)
            {
                Amount--;
            }
        }

        public void UpdateProductPrice(double updatedPrice)
        {
            const double minPrice = 0;

            if(updatedPrice > minPrice)
            {
                Price = updatedPrice;
            }
        }
    }
}