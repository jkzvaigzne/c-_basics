namespace AdApp
{
    public class TVAd : Advert
    {
        private int _seconds;
        private int _rate;
        private bool _isPeakTime;

        public TVAd(int fee, int airTimeInSeconds, int costPerSecond, bool isPeakTime) : base(fee)
        {
            _seconds = airTimeInSeconds;
            _rate = costPerSecond;
            _isPeakTime = isPeakTime;
        }

        public override int Cost()
        {
            int price = _seconds * _rate;

            if (_isPeakTime)
            {
                price *= 2;
            }
            return base.Cost() + price;
        }

        public override string ToString()
        {
            string peakTime = _isPeakTime ? "Yes" : "No";

            return base.ToString() + $"\nSeconds: {_seconds} \nCost per second: {_rate} \nIs peak time: {peakTime}";
        }
    }
}