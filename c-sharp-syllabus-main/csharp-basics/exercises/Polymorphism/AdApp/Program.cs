using System;

namespace AdApp
{
    class Program
    {
        static void Main()
        {
            var c = new Campaign("1188.lv");
            c.AddAdvert(new Advert(1000));
            c.AddAdvert(new Hoarding(500, 7, 200));
            c.AddAdvert(new NewspaperAd(0, 30, 20));
            c.AddAdvert(new TVAd(50000, 1000, 30, true));

            Console.WriteLine($"{c}\n");
            c.ShowAdverts();
            Console.ReadLine();
        }
    }
}
