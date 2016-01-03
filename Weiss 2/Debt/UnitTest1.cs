using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Debt
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PenaltiesGrade1()
        {
            Assert.AreEqual(52,MonthlyRent(50,2));
        }
        [TestMethod]
        public void PenaltiesGrade2()
        {
            Assert.AreEqual(200, MonthlyRent(100, 20));
        }

        decimal MonthlyRent(int initialRent, int days)
        {
            


            decimal a = (initialRent * getPenalty(days));
            return (a / 100) * days + initialRent;
        }
       private static int getPenalty(int days)
        {
            int[] timeIntervals = { 10, 30, 40 };
            int[] penalties = { 2, 5, 10 };
            if (days <= timeIntervals[0])
                return penalties[0];
            else if (days <= timeIntervals[1])
                return penalties[1];
            else if (days <= timeIntervals[2])
                return penalties[2];
        }
    }
}
                
         