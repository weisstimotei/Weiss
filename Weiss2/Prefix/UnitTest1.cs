using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Prefix
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestForA()
        {
            Assert.AreEqual("a",WordsPrefix("a","a"));
        }
         string WordsPrefix ( string firstWord, string secondWord)
        {
             return firstWord;
        }
    }
}
