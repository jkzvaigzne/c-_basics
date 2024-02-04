namespace VendingMachine
{
    public struct Money
    {
        public int Euros { get; set; }
        public int Cents { get; set; }

        public Money(int euros, int cents) => (Euros, Cents) = (euros, cents);

        public override string ToString() => $"{Euros},{Cents}";
    }
}
