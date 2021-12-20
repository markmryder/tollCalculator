using System;
using System.Collections.Generic;

namespace tollCalculator
{
	public class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Trip trip = new Trip(args[0], args[1]);
				trip.calculateTrip();
				Console.WriteLine($"Total cost of trip is: ${trip.TotalCost}");
			}
			catch(Exception e)
			{
				Console.WriteLine(e.Message);
				Console.WriteLine(e.StackTrace);
			}
			
			Console.WriteLine("Program has Ended");
		}
	}
}
