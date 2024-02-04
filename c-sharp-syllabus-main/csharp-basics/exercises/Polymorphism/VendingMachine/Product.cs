namespace VendingMachine
{
    public struct Product
    {
        public int Available { get; set; }
        public Money Price { get; set; }
        public string Name { get; set; }

        public Product(string name, Money price, int available) => (Name, Price, Available) = (name, price, available);

        public override string ToString() => $"Name: {Name}. Price: ${Price}. Available: {Available}";
    }
}


