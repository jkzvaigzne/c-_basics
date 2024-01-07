namespace Exercise4
{
    public class Movie
    {
        public string Title { get; }
        public string Studio { get; }
        public string Rating { get; }

        public Movie(string title, string studio, string rating = "PG")
        {
            Title = title;
            Studio = studio;
            Rating = rating;
        }
    }
}
