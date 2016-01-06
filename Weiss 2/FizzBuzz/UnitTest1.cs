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
        string GetFizzBuzz(int number)
        {
            if (number % 3 == 0)
                return "Fizz";
            else
                return " ";
        }
    }
}
