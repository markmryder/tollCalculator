using System;
using NUnit.Framework;
using tollCalculator;

namespace tollCalculatorTests
{
    public class TripsTest
    {


        [Test]
        public void CalculateTripBadStart()
        {
            Assert.Throws<Exception>(() => new Trip("Nowhere","Brock Road"));
        }
        [Test]
        public void CalculateTripBadEnd()
        {
            Assert.Throws<Exception>(() => new Trip("Brock Road", "Nowhere"));
        }
        [Test]
        public void CalculateTripGoodData()
        {
            Trip trip = new Trip("Jane Street", "Highway 27");
            trip.calculateTrip();
            Assert.AreEqual(2.03, trip.TotalCost);
        }
        [Test]
        public void CalculateTripGoodDataReverse()
        {
            Trip trip = new Trip("Highway 27", "Jane Street");
            trip.calculateTrip();
            Assert.AreEqual(2.03, trip.TotalCost);
        }

    }
}
