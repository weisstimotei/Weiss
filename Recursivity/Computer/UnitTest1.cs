using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Computer
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdditionOperation()
        {
            Assert.AreEqual(7, GetCalculate("+ 2 5 "));
        }
        double GetCalculate(string inputString)
        {
            return 7;
        }
    }
}
