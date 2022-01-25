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

		public Trip(string start, string end)
		{
			service = new LocationsService();
			service.LoadLocations();
			if(service.ValidateStartEnd(start, end))
			{
				Start = start;
				End = end;
			}
			else
			{
				throw new Exception("One of the location values are invalid");
			}	
		}

		public void calculateTrip()
		{
			RoadMap map = new RoadMap(service.locations);
			//map.DetermineDirection(Start, End);
			map.GetDistance(Start, End);
			TotalCost = Math.Round(map.Distance * rate, 2, MidpointRounding.AwayFromZero);
		}
	}
}
