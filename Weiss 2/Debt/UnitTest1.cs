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
        [TestMethod]
        public void PenaltiesGrade3()
        {
            Assert.AreEqual(500, MonthlyRent(100, 40));
        }
        decimal MonthlyRent(int initialRent, int days)
        {
            decimal a = (initialRent * GetPenalty(days));
            return (a / 100) * days + initialRent;
        }
       private static int GetPenalty(int days)
        {
            int[] timeIntervals = { 10, 30, 40 };
            int[] penalties = { 2, 5, 10 };
            if (days <= timeIntervals[0])
                return penalties[0];
            if (days <= timeIntervals[1])
                return penalties[1];
            else
                return penalties[2];
           
        }
    }
}
                
         