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
        [TestMethod]
        public void TestNoString()
        {
            Assert.AreEqual("", GetInvertingString(""));
        }
        string GetInvertingString(string inputString)
        {
            if (inputString.Length == 0)
            {
                return inputString;
            }
            return inputString[inputString.Length - 1] + GetInvertingString(inputString.Substring(0, inputString.Length - 1));
        }
    }
}
