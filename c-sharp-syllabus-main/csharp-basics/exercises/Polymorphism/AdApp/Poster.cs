namespace AdApp
{
    public class Poster : Advert
    {
        private int _width, _height, _count, _rate;

        public Poster(int fee, int height, int width, int units, int rate) : base(fee)
        {
            (_height, _width, _count, _rate) = (height, width, units, rate);
        }

        public override int Cost() => base.Cost() + _width * _height * _rate * _count;

        public override string ToString() => $"{base.ToString()}\nPoster width: {_width}\nPoster height: {_height}\nPoster count: {_count}\nPrice per cm: {_rate}";
    }
}
