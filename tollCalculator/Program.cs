using System;
using System.Collections.Generic;

namespace tollCalculator
{
	public class Program
	{
		static void Main(string[] args)
		{
			string start, stop;
			if(args.Length == 0)
            {
				Console.WriteLine("Enter starting point: ");
				start = Console.ReadLine();
				Console.WriteLine("Enter end point: ");
				stop = Console.ReadLine();
            }
            else
            {
				start = args[0];
				stop = args[1];
            }
			try
			{
				Trip trip = new Trip(start, stop);
				trip.calculateTrip();
				Console.WriteLine($"Total cost of trip is: ${trip.TotalCost}");
				Console.WriteLine($"Total distance travelled is: {trip.Distance} Km");
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
