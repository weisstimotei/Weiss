using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExcelColumns
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestForNumber1()
        {
            Assert.AreEqual("A", GetTheCodification(1));
        }
        [TestMethod]
        public void TestForNumber26()
        {
            Assert.AreEqual("Z", GetTheCodification(26));
        }
        [TestMethod]
        public void TestForNumber52()
        {
            Assert.AreEqual("AZ", GetTheCodification(52));
        }
        string GetTheCodification(int column)
    {
        string[] key = {"","A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
      if (column<=26)
            return key[column];
      if (column<=52)    
            return key[column /27]+key[column - 26];
      return "";
    }
    }
}
