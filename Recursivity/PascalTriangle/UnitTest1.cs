using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PascalTriangle
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestRow1()
        {
            CollectionAssert.AreEqual(new int[] { 1 }, GetPascalTriangle(1));
        }
        public int[] GetPascalTriangle(int row)
        {
            return new int[] { 1 };
        }
    }
}
