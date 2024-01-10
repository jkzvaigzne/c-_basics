using System.Linq;

namespace Exercise4
{
	public class MovieFilter
	{
		public static Movie[] GetPG(Movie[] movies)
		{
			return movies?.Where(m => m?.Rating == "PG").ToArray() ?? new Movie[0];
		}
	}
}
