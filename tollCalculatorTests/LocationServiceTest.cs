using System;
using NUnit.Framework;
using tollCalculator;

namespace tollCalculatorTests
{
	public class LocationServiceTest
	{
		private LocationsService service;

		[SetUp]
		public void Setup()
		{
			service = new LocationsService();
			service.LoadLocations("interchanges.json");
		}

		[Test]
		public void LoadLocationsTest()
		{
			int count = service.locations.Count;
			Assert.AreEqual(44, count);
		}

		[Test]
		public void LoadLocationsFromFileFails()
        {
			LocationsService service = new LocationsService();
            try
            {
				service.LoadLocations("wrong file path");
            }
            catch(Exception e)
            {
				Assert.AreEqual("Error reading file", e.Message);
            }
        }

		[Test]
		public void ValidateStartEndBadStart()
        {
			bool isValid = service.ValidateStartEnd("QEWWW", "Brock Road");
			Assert.IsFalse(isValid);
        }
		[Test]
		public void ValidateStartEndBadEnd()
		{
			bool isValid = service.ValidateStartEnd("QEW", "Brock");
			Assert.IsFalse(isValid);
		}
		[Test]
		public void ValidateStartGoodData()
		{
			bool isValid = service.ValidateStartEnd("QEW", "Brock Road");
			Assert.IsTrue(isValid);
		}
	}
}