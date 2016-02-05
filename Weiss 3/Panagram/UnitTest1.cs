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

        bool CheckForPanagram(string thePhrase)
        {
            int contor = 0;
            string loverCase = thePhrase.ToLower();
            char[] newString = loverCase.ToCharArray();
            for (int j = (char)('a'); j < 'z'; j++)
            {
                for (int i = 0; i < loverCase.Length; i++)
                {
                    if (newString[i] == j)
                        contor++;
                }
            }
                if(contor==25)
                    return true;
                return false;
        }
    }
}