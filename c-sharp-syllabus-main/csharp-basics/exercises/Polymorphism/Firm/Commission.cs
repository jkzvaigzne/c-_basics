namespace Firm
{
    internal class Commission : Hourly
    {
        private double _totalSales;
        private double _commissionRate;

        public Commission(string name, string address, string phone, string socSecNumber, double rate, double commissionRate)
            : base(name, address, phone, socSecNumber, rate) => _commissionRate = commissionRate;

        public void AddSales(double totalSales) => _totalSales += totalSales;

        public override double Pay() => base.Pay() + (_totalSales * (_totalSales = 0));

        public override string ToString() => $"{base.ToString()}\nTotal sales: {_totalSales}";
    }
}
