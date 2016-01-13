using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Cube
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestForFirstNumber()
        {
            Assert.AreEqual(192,getTheNumber(1));
        }
        int getTheNumber(int orderNumber)
        {
            int number=192;
            return number;
        }
    }
}
