using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Parquet
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            decimal parquet = NumberofParquet(1, 1, 1, 1);
            decimal forhelp = 115m/100;
                Assert.AreEqual( forhelp,parquet);
        }
        decimal NumberofParquet(decimal m, decimal n, decimal a, decimal b)
        {
            decimal Numberofgross = (m * n) / (a * b);
            decimal Numberofclear = (Numberofgross * 15) / 100 + Numberofgross;
            return Numberofclear;
        }
    }
}
