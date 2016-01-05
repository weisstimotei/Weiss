using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Archaeological_site
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double test = CalculateTheMinimumArea(0, 3, 4, 0, 0, 0);
            Assert.AreEqual(6, test);
        }
        double CalculateTheMinimumArea(double ax, double ay, double bx, double by, double cx, double cy)
        {
            // ax, ay, bx, by, cx, cy are the coordinates of the three columns
            double a = SideA(bx, by, cx, cy);
            double b = SideB(ax, ay, cx, cy);
            double c = Math.Sqrt((bx - ax) * (bx - ax) + (by - ay) * (by - ay));
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        private static double SideB(double ax, double ay, double cx, double cy)
        {
            double b = Math.Sqrt((cx - ax) * (cx - ax) + (cy - ay) * (cy - ay));
            return b;
        }

        private static double SideA(double bx, double by, double cx, double cy)
        {
            double a = Math.Sqrt((cx - bx) * (cx - bx) + (cy - by) * (cy - by));
            return a;
        }
    }
}
