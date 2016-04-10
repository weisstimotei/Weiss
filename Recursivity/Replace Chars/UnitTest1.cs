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
        [TestMethod]
        public void TestForOneLeter()
        {
            Assert.AreEqual("alo", GetReplaceChars("a", "alo", "a"));
        }
        string GetReplaceChars(string inputString, string wordToReplace, string charReplaced)
        {
            string result = string.Empty;
            if (inputString.Length <= 1)
                return (inputString[0].ToString().Contains(charReplaced)) ? wordToReplace : inputString;
            if (inputString[inputString.Length - 1].ToString().Contains(charReplaced))
             {
                 return GetReplaceChars(inputString.Substring(0, inputString.Length - 1), wordToReplace, charReplaced) + wordToReplace;
             }

            return GetReplaceChars(inputString.Substring(0, inputString.Length - 1), wordToReplace, charReplaced) + inputString[inputString.Length - 1];
        }
    }
}
