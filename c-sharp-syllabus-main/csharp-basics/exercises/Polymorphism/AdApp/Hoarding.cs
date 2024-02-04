namespace AdApp
{
    public class Hoarding : Advert
    {
        private int _rate;
        private int _numDays;
        private bool _isPrimeLocation;

        public Hoarding(int fee, int costPerDay, int daysHired) : base(fee)
        {
            _rate = costPerDay;
            _numDays = daysHired;
            _isPrimeLocation = false;
        }

        public void SetPrimeLocation()
        {
            _isPrimeLocation = true;
        }

        public override int Cost()
        {
            int price = _numDays * _rate;
            if (_isPrimeLocation)
            {
                price += (int)(price * 0.5);
            }

            return base.Cost() + price;
        }

        public override string ToString()
        {
            string primeLocation = _isPrimeLocation ? "Yes" : "No";

            return base.ToString() + $"\nDays hired: {_numDays} \nRate: {_rate} \nIs prime location: {primeLocation}";
        }
    }
}