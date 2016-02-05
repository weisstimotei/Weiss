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
        [TestMethod]
        public void AnagramsWithRepeatedChars()
        {
            Assert.AreEqual(30, GetTheNumberOfAnagram("aaccd"));
        }
        [TestMethod]
        public void TestFoConversionToLowercase()
        {
            Assert.AreEqual(3, GetTheNumberOfAnagram("Aab"));
        }
        int GetTheNumberOfAnagram(string theWord)
        {
            string lowerCase = theWord.ToLower();
            int result;
            if (theWord.Length == 0)
                return 0;
            result = GetTheFactorial(lowerCase.Length) / CountOfRepeatedChars(lowerCase);
            return result;
           }

        
        int CountOfRepeatedChars(string inputstring)
        {
            int result = 0;
            int p = 1;
            for (char charToCheck = 'a'; charToCheck <= 'z'; charToCheck++)
            {
                result = CountOfChars(inputstring, charToCheck);
                p *= GetTheFactorial(result);
            }
            return p;
        }

       private static int CountOfChars(string inputstring, char charToCheck)
        {
            int result = 0;
            for (int i = 0; i < inputstring.Length; i++)
            {
                if (inputstring[i] == charToCheck)
                {
                    result++;
                }
            }
            return result;
        }
       int GetTheFactorial(int length)
       {
           int theNumber = 1;
           for (int i = 1; i <= length; i++)
           {
               theNumber *= i;
           }
           return theNumber;
       }
    }
}
