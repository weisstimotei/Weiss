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
        [TestMethod]
        public void ObtainFizzBuzz()
        {
            Assert.AreEqual("FizzBuzz", GetFizzBuzz(30));
        }
        [TestMethod]
        public void ForAnotherNumbers()
        {
            Assert.AreEqual("Put another value", GetFizzBuzz(31));
        }
        string GetFizzBuzz(int number)
        {
            if (number % 3 ==0 && number % 5 == 0)
                return "FizzBuzz";
            if (number % 5 == 0)
                return "Buzz";
            if (number % 3 == 0)
                return "Fizz";
            else
                return "Put another value";
        }
    }
}
