using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Password
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestForGetPassword1()
        {
            Assert.AreEqual("",GetPassword(0));
        }
        string GetPassword(int length)
        {
            return "";
        }
    }
}
