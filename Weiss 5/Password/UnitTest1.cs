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
            Assert.AreEqual("", GetPassword(0));
        }

        string GetPassword(int length)
        {
            return "";
        }
        public struct Options
        {
            public int smallChars;
            public int noOfUpperChars;
            public int noOfNumbers;
            public int noOfSymbols;
            public bool notIncludedSimilarChars;
            public bool notIncludedAmbigueChars;

            public Options(int smallChars, int noOfUpperChars, int noOfNumbers, int noOfSymbols, bool notIncludedSimilarChars, bool notIncludedAmbigueChars)
            {
                this.smallChars = smallChars;
                this.noOfUpperChars = noOfUpperChars;
                this.noOfNumbers = noOfNumbers;
                this.noOfSymbols = noOfSymbols;
                this.notIncludedSimilarChars = notIncludedSimilarChars;
                this.notIncludedAmbigueChars = notIncludedAmbigueChars;
            }
        }
    }
}

