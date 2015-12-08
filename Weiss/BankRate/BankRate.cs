﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankRate
{
    [TestClass]
    public class BankRate
    {
        [TestMethod]
        public void RateForFirstMonth()
        {
            decimal rate = CalculateBankRate(200, 2, 12, 1);
                Assert.AreEqual(102,rate);
        }

        [TestMethod]
        public void RateForSecondMonth()
        {
            decimal rate = CalculateBankRate(200, 2, 12, 2);
            Assert.AreEqual(101, rate);
        }

        decimal CalculateBankRate(decimal total, int periodInMonths, decimal interestPerYear, int currentMonth)
        {
            decimal principal = total / periodInMonths;
            decimal exactInterestPerYear = interestPerYear / 12 / 100;
            decimal sold = total - (currentMonth - 1) * principal;
            return principal + sold * exactInterestPerYear ;
        }
    }
}
