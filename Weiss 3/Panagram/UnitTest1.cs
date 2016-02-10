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
            int contor = 0;
            string lowerCase = thePhrase.ToLower();
            string[] pangramContents = new string[26] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            for (int i = 0; i < pangramContents.Length; i++)
            {
                if (!lowerCase.Contains(pangramContents[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
