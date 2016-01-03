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
            Assert.AreEqual(55,MonthlyRent(50,2));
        }
        decimal MonthlyRent(int initialRent, int days)
        {
            int[] penalties = {5 };
            decimal a = (initialRent * penalties[0]);
            return (a / 100) * days + initialRent;
        }
    }
}
