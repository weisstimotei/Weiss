using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RomanNumerals
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void number1()
        {
            Assert.AreEqual("I", RomanNumberConvertor(1));
        }
        [TestMethod]
        public void number10()
        {
            Assert.AreEqual("X", RomanNumberConvertor(10));
        }
        [TestMethod]
        public void number50()
        {
            Assert.AreEqual("L", RomanNumberConvertor(50));
        }
        public static string RomanNumberConvertor(int number)
        {
            string[] codification = {"","X","XX","XXX","XL","L","LX","LXX","LXXX","XC",
               "","I","II","III","IV","V","VI","VII","VIII","IX"};
            if (number == 100)
                return "C";
            if (number >= 10)
                return codification[number / 10] + codification[10 + number % 10];
            else return codification[10 + number];
        }
    }
}
