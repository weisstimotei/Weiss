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
            Assert.AreEqual(55,MonthlyRent(50,5,2));
        }
        decimal MonthlyRent(int initialRent,int penalties, int days)
        {
            decimal a = (initialRent * penalties);
            return (a / 100) * days + initialRent;
        }
    }
}
