using System.Collections.Generic;

namespace FlightPlanner
{
	public class Flight
	{
		public string DepartureCity { get; }
		public List<string> DestinationCities { get; }

		public Flight(string departureCity, List<string> destinationCities)
		{
			DepartureCity = departureCity;
			DestinationCities = destinationCities;
		}
	}
}