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
			Start = start;
			End = end;
		}
	}
}
