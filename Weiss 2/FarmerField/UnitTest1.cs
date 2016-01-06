using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace FarmerField
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LengthPositive()
        {
            Assert.AreEqual(770,LengthField(230,770000));
        }
        double LengthField(int width, int totalArea)
        {
            double x1 = GetX1(width, totalArea);
            double x2 = GetX2(width, totalArea);
            if (x1 > 0)
                return x1;
            else
                return x2;
        }

        private static double GetX2(int width, int totalArea)
        {
            double x2 = (-width - Math.Sqrt(width * width - 4 * (-totalArea))) / 2;
            return x2;
        }

        private static double GetX1(int width, int totalArea)
        {
            double x1 = (Math.Sqrt(width * width - 4 * (-totalArea)) - width) / 2;
            return x1;
        }
    }
}
