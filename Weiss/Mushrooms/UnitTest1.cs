using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mushrooms
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            decimal number = TheMushroomsred(15, 4);
            Assert.AreEqual(12, number);
        }
        int TheMushroomsred(int n, int x)
        {
            int Red = n * x / (x + 1);
            return Red;
        }
    }
}
