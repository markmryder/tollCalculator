using System;
using System.Collections.Generic;
using System.Text;

namespace tollCalculator
{
	public class Trip
	{
		public string Start { get; set; }
		public string End { get; set; }
		private LocationsService service { get; set; }
		private double rate { get; } = 0.25;
		public double TotalCost { get; set; }
		public RoadMap map { get; set; }
		public double Distance { get; set; }

		public Trip(string start, string end)
		{
			service = new LocationsService();
			//Normally load from resources or some external path
			service.LoadLocations("interchanges.json");
			if(service.ValidateStartEnd(start, end))
			{
				Start = start;
				End = end;
				map = new RoadMap(service.locations);
				map.GetDistance(Start, End);
			}
			else
			{
				throw new Exception("One of the location values are invalid");
			}	
		}

		public void calculateTrip()
		{
			TotalCost = Math.Round(map.Distance * rate, 2, MidpointRounding.AwayFromZero);
			Distance = Math.Round(map.Distance, 2, MidpointRounding.AwayFromZero);
		}
	}
}
