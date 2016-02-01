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
        string CheckForPanagram(string sentenceInserted)
        {
            string lowerCase = sentenceInserted.ToLower();
            if (CheckPanagram(lowerCase))
                return "YES";
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
