using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sports
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
         {
            int a = Rounds(7);
            Assert.AreEqual(49,a);

        }
        int Rounds(int n)
        {
            int rehearsal = n * n;
            return rehearsal;
        }
    }
}
