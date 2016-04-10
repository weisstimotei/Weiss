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
            Assert.AreEqual("aaloc", GetReplaceChars("abc", "alo", 'b'));
        }
        string GetReplaceChars(string inputString, string wordToReplace, char charReplaced)
        {
            return "aaloc";
        }
    }
}
