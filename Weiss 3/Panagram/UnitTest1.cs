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
            Assert.AreEqual(true, CheckForPanagram("The quick brown fox jumps over the lazy dog"));
        }

        bool CheckForPanagram(string thePhrase)
        {
            int[] numbers = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            char[] newString = thePhrase.ToCharArray();
            for (int i = 0; i < thePhrase.Length; i++)
            {
                for (int j = 0; j < 26; j++)
                {
                    if (newString[i] == (char)('a' + j))
                        numbers[j] = numbers[j] + 1;
                }
            }
            int counter = 0;
            for (int i = 0; i < 26; i++)
            {
                if (numbers[i] == 0)
                    counter++;
            }
            if (counter==0)
                return true;
            return false;
        }
    }
}