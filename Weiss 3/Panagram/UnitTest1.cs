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
            Assert.AreEqual(false, CheckForPanagram("Abcfdhfs"));
        }
        [TestMethod]
        public void CheckPanagramForAlphabet()
        {
            Assert.AreEqual(true, CheckForPanagram("abcdefghijklmnopqrstuvwxyz"));
        }
        [TestMethod]
        public void CheckPanagramForAPanagram()
        {
            Assert.AreEqual(true, CheckForPanagram("The quick brown fox jumps over the lazy dog"));
        }

        bool CheckForPanagram(string thePhrase)
        {
            string lowerCase = thePhrase.ToLower();
            for (int i = 0; i < 26; i++)
            {
                if (!lowerCase.Contains(GetStringAlphabet(i)))
                {
                    return false;
                }
            }
            return true;
        }
        public static string GetStringAlphabet(int i)
        {

            string stringAlphabet = Convert.ToString((char)('a' + i));
           
            return stringAlphabet;
        }
    }
}
