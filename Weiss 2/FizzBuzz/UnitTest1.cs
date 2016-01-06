using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ObtainFizz()
        {
            Assert.AreEqual("Fizz",GetFizzBuzz(9));
        }
        [TestMethod]
        public void ObtainBuzz()
        {
            Assert.AreEqual("Buzz", GetFizzBuzz(25));
        }
        string GetFizzBuzz(int number)
        {
            if (number % 3 == 0)
                return "Fizz";
            if (number % 5 == 0)
                return "Buzz";
            else
                return " ";
        }
    }
}
