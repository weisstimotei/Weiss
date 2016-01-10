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
        [TestMethod]
        public void TestForAAA()
        {
            Assert.AreEqual("aaa", WordsPrefix("aaacc", "aaaa"));
        }
        [TestMethod]
        public void TestForEmpty()
        {
            Assert.AreEqual("", WordsPrefix("bbb", "abc"));
        }
         string WordsPrefix ( string firstWord, string secondWord)
        {
            string prefix = string.Empty;
            int TheShortestWord = Math.Min(firstWord.Length, secondWord.Length);
            for ( int i = 0; i < TheShortestWord; i++)
            {
                if (firstWord[i] == secondWord[i]) prefix += firstWord[i];
                else break;
            }
            return prefix;
        }
    }
}
