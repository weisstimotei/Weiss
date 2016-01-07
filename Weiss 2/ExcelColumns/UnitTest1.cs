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
        string GetTheCodification(int column)
    {
        string[] key = {"","A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
        return key[column];
    }
    }
}
