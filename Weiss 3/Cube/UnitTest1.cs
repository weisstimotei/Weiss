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
        [TestMethod]
        public void TestForNumber692()
        {
            Assert.AreEqual(692, getTheNumber(3));
        }
        int getTheNumber(int orderNumber)
        {
            int number=192;
            for (int i = 1; i <orderNumber ; i++)
                number += 250;
            return number;
        }
    }
}
