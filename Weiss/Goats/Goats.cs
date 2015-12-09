using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Goats
{
    [TestClass]
    public class Goats
    {
        [TestMethod]
        public void TestMethod1()
        {
            decimal kilo = Kilogramsofhay(1, 1, 1, 2, 2);
            Assert.AreEqual(1, kilo);
        }
        decimal Kilogramsofhay(int x, int y, decimal z, int w, int q)
        {
            decimal kiloofhay = (z * q * x) / (w * y);
            return kiloofhay;

        }
    }
}
