using tollCalculator;
using System;
using NUnit.Framework;
using System.Collections.Generic;

namespace tollCalculatorTests
{
    public class RoadMapTest
    {
        private RoadMap map;

        [SetUp]
        public void Setup()
        {
            
            LocationsService service = new LocationsService();
            service.LoadLocations("interchanges.json");
            map = new RoadMap(service.locations);

        }

        [Test]
        public void GetDistanceEastboundTest()
        {
            map.GetDistance("QEW", "Brock Road");
            Assert.AreEqual(107.964, map.Distance);
        }
        [Test]
        public void GetDistanceWestboundTest()
        {
            map.GetDistance("Brock Road", "QEW");
            Assert.AreEqual(107.964, map.Distance);
        }

    }
}