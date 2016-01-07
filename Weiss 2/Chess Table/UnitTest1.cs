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
        decimal GetChessTableSquares(int size)
        {
            return 1; 
        }
    }
}
