using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace tollCalculator
{

	public class Locations
	{
		[JsonProperty("locations")]
		public Dictionary<string, Location> locations { get; set; }
	}
	public class LocationsService
	{
		public Dictionary<string, Location> locations { get; set; }

		public void LoadLocations()
		{

			StreamReader sr = new StreamReader("interchanges.json");
			string json = sr.ReadToEnd();
			locations = JsonConvert.DeserializeObject<Locations>(json).locations;
		}

		public bool ValidateStartEnd(string start, string end)
		{
			bool isStartValid = false;
			bool isEndValid = false;
			foreach(Location location in locations.Values)
			{
				if (start.Equals(location.Name))
				{
					isStartValid = true;
					Console.WriteLine("Start is good");
				}
				if (end.Equals(location.Name))
				{
					isEndValid = true;
					Console.WriteLine("End is good");
				}
			}
			return isEndValid && isStartValid;
		}

	}
}
