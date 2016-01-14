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
            int shortestWordLenght = Math.Min(firstWord.Length, secondWord.Length);
            for ( int i = 0; i < shortestWordLenght; i++)
            {
                if (getTheComparison(firstWord, secondWord, i))
                    break;
                    prefix += firstWord[i];
                
            }
            return prefix;
        }

         private static bool getTheComparison(string firstWord, string secondWord, int i)
         {
             return !(firstWord[i] == secondWord[i]);
         }
    }
}
