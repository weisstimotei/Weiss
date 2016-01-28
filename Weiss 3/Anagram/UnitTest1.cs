using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Anagram
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FirstTest()
        {
            Assert.AreEqual(6,GetTheNumberOfAnagram("CAI"));
        }
        double GetTheNumberOfAnagram(string theWord)
        {
            return  GetTheNumber(theWord);
        }

        private static int GetTheNumber(string theWord)
        {
            int theNumber = 1;
            for (int i = 1; i <= theWord.Length; i++)
            {
                theNumber *= i;
            }
            return theNumber;
        }
    }
}
