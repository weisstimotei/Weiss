using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Taxi_fare
{
    [TestClass]
    public class TaxiFare
    {
        [TestMethod]
        public void DaytimeFareForShortDistances()
        {
            Assert.AreEqual(5, CalculateTaxiFare(1, 8));
        }
        [TestMethod]
        public void DaytimeFareForMediumDistances()
        {
            Assert.AreEqual(168, CalculateTaxiFare(21, 8));
        }

        decimal CalculateTaxiFare(int distanceInKm, int hour)
        {
           decimal pricePerKm = distanceInKm > 20 ? 8 : 5;
            return distanceInKm * pricePerKm;

        }

    }
}
