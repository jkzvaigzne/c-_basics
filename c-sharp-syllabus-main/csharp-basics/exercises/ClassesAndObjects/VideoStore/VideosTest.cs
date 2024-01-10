using System;

namespace VideoStore
{
    public class VideoStoreTest
    {
        public static void Test()
        {
            var vs = new VideoStore();

            vs.AddVideo("The Matrix");
            vs.AddVideo("Godfather II");
            vs.AddVideo("Star Wars Episode IV: A New Hope");

            vs.GiveRating("The Matrix", 4.1);
            vs.GiveRating("The Matrix", 4.0);
            vs.GiveRating("Godfather II", 5.0);
            vs.GiveRating("Godfather II", 4.9);
            vs.GiveRating("Star Wars Episode IV: A New Hope", 4.2);

            vs.RentVideo("The Matrix");

            vs.ReturnVideo("The Matrix");
            vs.ReturnVideo("Godfather II");

            Console.WriteLine("Inventory after renting 'Godfather II':");
            vs.ListAllVideos();

            vs.ReturnVideo("Godfather II");
            vs.ReturnVideo("Star Wars Episode IV: A New Hope");

            vs.RentVideo("Star Wars Episode IV: A New Hope");

            Console.Read();
        }
    }
}
