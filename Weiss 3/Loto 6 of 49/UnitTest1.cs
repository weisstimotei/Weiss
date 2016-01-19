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
        [TestMethod]
        public void TestForCategory2()
        {
            Assert.AreEqual((5.244158E-07), getProbability(2, 6, 49),1E-5);
        }
        [TestMethod]
        public void TestForCategory3()
        {
            Assert.AreEqual((4.719742E-06), getProbability(3, 6, 49), 1E-5);
        }
        double getProbability(float category, float howMuch, float of)
        {
            return (getPermutations(howMuch) / getPermutations(howMuch-category+1) * getPermutations(category-1))*(getPermutations(49-howMuch) / getPermutations(category-1) * getPermutations(49-howMuch-category+1))/(getPermutations(of) / getPermutations(howMuch) * getPermutations(of - howMuch));

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
