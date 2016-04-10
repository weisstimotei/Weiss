using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Replace_Chars
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCheckReplacement()
        {
            Assert.AreEqual("aaloc", GetReplaceChars("abc", "alo", "b"));
        }
        [TestMethod]
        public void TestSwapWithTwoLeters()
        {
            Assert.AreEqual("aaloaloc", GetReplaceChars("abbc", "alo", "b"));
        }
        string GetReplaceChars(string inputString, string wordToReplace, string charReplaced)
        {
            string result = string.Empty;
            if (!inputString.Contains(charReplaced))
             {
                 return inputString;
             }

             return inputString.Replace(charReplaced.ToString(),wordToReplace);
        }
    }
}
