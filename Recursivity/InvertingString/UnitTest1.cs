using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InvertingString
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestInitial()
        {
            Assert.AreEqual("anuB",GetInvertingString("Buna"));
        }
        string GetInvertingString(string inputString)
        {
            return "anuB";
        }
    }
}
