using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie firstMovie = new Movie("Casino Royale", "Eon Productions", "PG-13");
            Movie secondMovie = new Movie("Glass", "Buena Vista International", "PG-13");
            Movie thirdMovie = new Movie("Spider-Man: Into the Spider-Verse", "Columbia Pictures");

            Console.WriteLine($"Movie: {firstMovie.Title}, {firstMovie.Studio}, {firstMovie.Rating}");
            Console.WriteLine($"Movie: {secondMovie.Title}, {secondMovie.Studio}, {secondMovie.Rating}");
            Console.WriteLine($"Movie: {thirdMovie.Title}, {thirdMovie.Studio}, {thirdMovie.Rating}");

            Movie[] movieArray = new Movie[] { firstMovie, secondMovie, thirdMovie };

            Movie[] pgMovies = MovieFilter.GetPG(movieArray);
            
            Console.WriteLine();
            Console.WriteLine("PG Movies:");
            foreach (var movie in pgMovies)
            {
                Console.WriteLine($"{movie.Title}, {movie.Studio}, {movie.Rating}");
            }

            Console.Read();
        }
    }
}
