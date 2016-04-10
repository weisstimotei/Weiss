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
            CollectionAssert.AreEqual(new int[] { 1 }, GetPascalRow(1));
        }
        [TestMethod]
        public void TestRow3()
        {
            CollectionAssert.AreEqual(new int[] { 1, 2, 1 }, GetPascalRow(3));
        }
        [TestMethod]
        public void TestRow7()
        {
            CollectionAssert.AreEqual(new int[] { 1, 6, 15, 20, 15, 6, 1 }, GetPascalRow(7));
        }
        public int[] GetPascalRow(int numberOfRow)
        {
            int[] output = new int[numberOfRow];
            if (numberOfRow == 1)
            {
                return new int[] { 1 };
            }
            output[0] = 1;
            output[numberOfRow - 1] = 1;
            int[] beforeRow = GetPascalRow(numberOfRow - 1);
            for (int i = 1; i < numberOfRow - 1; i++)
            {
                output[i] = beforeRow[i - 1] + beforeRow[i];
            }
            return output;
        }
       
    }
}
