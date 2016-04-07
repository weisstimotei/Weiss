using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Fibonacci
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestWhenTheNumberIs6()
        {
            Assert.AreEqual(8,GetFibonacci(6));
        }
        int GetFibonacci(int number)
        {
            if (number < 2) 
                return number;
            return (GetFibonacci(number - 1) + GetFibonacci(number - 2));
        }
    }
}
