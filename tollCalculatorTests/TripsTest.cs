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
            
            try
            {
                Trip trip = new Trip("Nowhere", "Brock Road");
            }
            catch (Exception e)
            {
                Assert.AreEqual(e.Message, "One of the location values are invalid");
            }
        }
        [Test]
        public void CalculateTripBadEnd()
        {
            
            try
            {
                Trip trip = new Trip("Jane Street", "Bad string");
            }
            catch(Exception e)
            {
                Assert.AreEqual(e.Message, "One of the location values are invalid");
            }
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
