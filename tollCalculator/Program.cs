using System;
using System.Collections.Generic;

namespace tollCalculator
{
	public class Program
	{
		static void Main(string[] args)
		{
			//either use command line arguments or have user enter
			//lets assume command line
			try
			{
				Trip trip = new Trip(args[0], args[1]);
			}
			catch(Exception e)
			{
				Console.WriteLine(e.Message);
			}
			

			Console.WriteLine("Program has Ended");
		}
	}
}
