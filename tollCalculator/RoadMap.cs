using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tollCalculator
{
	public enum Direction
	{
		EASTBOUND,
		WESTBOUND
	}
	public class RoadMap
	{
		public List<Location> Eastbound { get; set; }
		public List<Location> Westbound { get; set; }
		public double Distance { get; set; }
		public Direction direction { get; set; }



		Dictionary<string, Location> _locations { get; set; }
		public RoadMap(Dictionary<string,Location> locations)
		{
			_locations = locations;
			Eastbound = new List<Location>();
			Westbound = new List<Location>();
			CreateEastbound(locations);
			CreateWestbound(locations);
		}

		public void GetDistance(string start, string end)
		{
			if(direction == Direction.EASTBOUND)
			{
				var startLocation = Eastbound.FirstOrDefault<Location>(x => x.Name.Equals(start));
				var endLocation = Eastbound.FirstOrDefault<Location>(x => x.Name.Equals(end));
				int startIndex = Eastbound.IndexOf(startLocation);
				int endIndex = Eastbound.IndexOf(endLocation);

				double distance = 0f;

				Console.WriteLine(startIndex);
				Console.WriteLine(endIndex);
				for(int i = startIndex; i < endIndex; i++)
				{
					distance += Eastbound[i].Routes[0].Distance;
					distance = Math.Round(distance, 4, MidpointRounding.AwayFromZero);
					Console.WriteLine(distance);
				}
				Distance = distance;
				Console.WriteLine($"Total distance travelled: {distance}");
			}
			else
			{
				var startLocation = Westbound.FirstOrDefault<Location>(x => x.Name.Equals(start));
				var endLocation = Westbound.FirstOrDefault<Location>(x => x.Name.Equals(end));
				int startIndex = Westbound.IndexOf(startLocation);
				int endIndex = Westbound.IndexOf(endLocation);

				double distance = 0f;

				Console.WriteLine(startIndex);
				Console.WriteLine(endIndex);
				for (int i = startIndex; i < endIndex; i++)
				{
					distance += Westbound[i].Routes[1].Distance;
					distance = Math.Round(distance, 4, MidpointRounding.AwayFromZero);
					Console.WriteLine(distance);
				}
				Distance = distance;
				Console.WriteLine($"Total distance travelled: {distance}");
			}
		}

		private void CreateEastbound(Dictionary<string, Location> locations)
		{
			Eastbound.Clear();
			foreach(Location location in locations.Values)
			{
				Eastbound.Add(location);
			}
		}
		private void CreateWestbound(Dictionary<string, Location> locations)
		{
			Westbound.Clear();
			foreach (Location location in locations.Values)
			{
				Westbound.Add(location);
			}
			Westbound.Reverse();
		}

		public void DetermineDirection(string start, string end)
		{
			int iStart;
			int iEnd;

			var startLocation = _locations.FirstOrDefault(x => x.Value.Name.Equals(start));
			var endLocation = _locations.FirstOrDefault(x => x.Value.Name.Equals(end));
			iStart = Int32.Parse(startLocation.Key);
			iEnd = Int32.Parse(endLocation.Key);

			if(iStart < iEnd)
			{
				direction = Direction.EASTBOUND;
				Console.WriteLine("Direction is Eastbound");
			}
			else
			{
				direction = Direction.WESTBOUND;
				Console.WriteLine("Direction is Westbound");
			}
		}


	}
}
