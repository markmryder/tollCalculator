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

		public void LoadLocations(string filepath)
		{
            try
            {
				StreamReader sr = new StreamReader(filepath);
				string json = sr.ReadToEnd();
				locations = JsonConvert.DeserializeObject<Locations>(json).locations;
			}
			catch(Exception e)
            {
				throw new Exception("Error reading file");
            }
			
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
				}
				if (end.Equals(location.Name))
				{
					isEndValid = true;
				}
			}
			return isEndValid && isStartValid;
		}

	}
}
