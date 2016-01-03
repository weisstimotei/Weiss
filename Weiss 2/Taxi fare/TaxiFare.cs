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

        decimal CalculateTaxiFare(int distanceInKm, int hour)
        {
            return distanceInKm = 5;
        }

    }
}
