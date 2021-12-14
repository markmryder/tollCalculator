using System;
using System.Collections.Generic;
using System.Text;

namespace tollCalculator
{
	public class Trip
	{
		public string Start { get; set; }
		public string End { get; set; }

		public Trip(string start, string end)
		{
			LocationsService service = new LocationsService();
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

		}
	}
}
