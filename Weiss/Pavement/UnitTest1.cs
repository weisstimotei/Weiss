using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pavement
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            decimal test = CalculateNumberOfStones(6, 6, 4);
            Assert.AreEqual(4, test);
        }
      
        decimal CalculateNumberOfStones(decimal squareLenght, decimal squareWidth, decimal cobblestoneSide)
        {
            decimal lenght = Math.Ceiling(squareLenght / cobblestoneSide);
            decimal width = Math.Ceiling(squareWidth / cobblestoneSide);
            return lenght * width;
        }
    }
}
