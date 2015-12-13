using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Trains
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double distanceflown = CalculateTheDistanceOfFlown(200,1,2);
            Assert.AreEqual(100, distanceflown);
        }
      double CalculateTheDistanceOfFlown(double TotalDistance, double SpeedOfTrains, double SpeedOfBird)
        {
            double total = TotalDistance / 2; // bird walking distance is not influenced by speeds
            return total;
        }
    }
}
