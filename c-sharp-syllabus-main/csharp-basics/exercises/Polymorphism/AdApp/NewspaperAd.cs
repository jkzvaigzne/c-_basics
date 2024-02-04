namespace AdApp
{
    public class NewspaperAd : Advert
    {
        private int _column;
        private int _rate;

        public NewspaperAd(int fee, int rate, int columnCm) : base(fee)
        {
            _rate = rate;
            _column = columnCm;
        }

        public override int Cost()
        {
            return base.Cost() + _column * _rate;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nCentimeters in column: {-_column} \nPrice per cm: {_rate}";
        }
    }
}