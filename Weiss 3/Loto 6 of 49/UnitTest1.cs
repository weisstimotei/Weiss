using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Loto_6_of_49
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestForCategory1()
        {
            Assert.AreEqual((7.151E-08), getProbability(1, 6, 49), 1E-3);
        }
        double getProbability(float category, float howMuch, float of)
        {
            return getPermutations(howMuch)*getPermutations(of-howMuch)/getPermutations(of);
 
        }
        double getPermutations(float number)
        {
            double product = 1;
            for (int i = 1; i <= number; i++)
            {
                product *= i;
            }
            return product;
        }
    }
}
