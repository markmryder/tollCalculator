using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tollCalculator
{
	
	public class RoadMap
	{
		public List<Location> Eastbound { get; set; }
		public List<Location> Westbound { get; set; }
		public List<Location> Exits { get; set; }
		public double Distance { get; set; }



		Dictionary<string, Location> _locations { get; set; }
		public RoadMap(Dictionary<string,Location> locations)
		{
			_locations = locations;
			Exits = new List<Location>();
			CreateExits(locations);
		}

		public void GetDistance(string start, string end)
		{
			var startLocation = Exits.FirstOrDefault<Location>(x => x.Name.Equals(start));
			var endLocation = Exits.FirstOrDefault<Location>(x => x.Name.Equals(end));
			int startIndex = Exits.IndexOf(startLocation);
			int endIndex = Exits.IndexOf(endLocation);
			double distance = 0f;

			if (startIndex < endIndex)
			{
				for (int i = startIndex; i < endIndex; i++)
				{
					distance += Exits[i].Routes[0].Distance;
					distance = Math.Round(distance, 4, MidpointRounding.AwayFromZero);
					Console.WriteLine(distance);
				}
				Distance = distance;
			}
			else
			{
				for (int i = startIndex; i > endIndex; i--)
				{
					distance += Exits[i].Routes[1].Distance;
					distance = Math.Round(distance, 4, MidpointRounding.AwayFromZero);
					Console.WriteLine(distance);
				}
				Distance = distance;
			}
			Console.WriteLine($"Total distance travelled: {distance}");
		}

		private void CreateExits(Dictionary<string,Location> locations)
		{
			Exits.Clear();
			foreach(Location location in locations.Values)
			{
				Exits.Add(location);
			}
		}

	}
}
