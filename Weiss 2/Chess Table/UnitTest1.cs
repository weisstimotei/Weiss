using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chess_Table
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ForSize1()
        {
            Assert.AreEqual(1,GetChessTableSquares(1));
        }
        [TestMethod]
        public void ForSize2()
        {
            Assert.AreEqual(5, GetChessTableSquares(2));
        }
        [TestMethod]
        public void ForSize8()
        {
            Assert.AreEqual(204, GetChessTableSquares(8));
        }
        decimal GetChessTableSquares(int size)
        {
            int total = 0;
            for (int i = 1; i <= size; i++)
            {
                total += i * i;
            }
                return total; 
        }
    }
}
