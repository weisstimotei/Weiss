using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Panagram
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckPanagramForARandomString()
        {
            Assert.AreEqual("NO", CheckForPanagram("Abcfdhfs"));
        }
        [TestMethod]
        public void CheckPanagramForAlphabet()
        {
            Assert.AreEqual("Yes", CheckForPanagram("the quick brown fox jumps over the lazy dog"));
        }
       
        string CheckForPanagram(string sentenceInserted)
        {
            string lowerCase = sentenceInserted.ToLower();
            if (CheckPanagram(lowerCase))
                return "YES";
            else 
                return "NO";
        }
        bool CheckPanagram(string inputString)
        {
            int i = 0;
            string output = string.Empty;
            for (int j = 0; j < inputString.Length; j++)
            {
                while ((char)('a' + i) != inputString[j] && i != 26)
                {
                    i++;
                    return false;

                }
            }
            return true;
        }
    }
}
