using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Password
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestForGetPassword1()
        {
            Assert.AreEqual("",GetPassword(0));
        }
        [TestMethod]
        public void TestForGetLowerCase()
        {
            string a = GetLowerCase(5);
            bool actual = CheckSmallLettersOfAString(a);
            Assert.AreEqual(true, actual);
        }
        [TestMethod]
        public void TestForGetUpperCase()
        {
            string a =GetUpperCase(5);
            bool actual = CheckBigLettersOfAString(a);
            Assert.AreEqual(true, actual);
        }
        string GetPassword(int length)
        {
            return "";
        }
        string GetLetters(int length)
        {
           string output = string.Empty;
           Random rand = new Random();

           while (length != 0)
            {
                int randomNumber = rand.Next(0, 26);
                char holdChar = (char)('a' + randomNumber);
                output += holdChar;
                length--;
            }
            return output;
        }
        string GetLowerCase(int length)
        {
            string lowerCase = GetLetters(length).ToLower();
            return lowerCase;
        }
        string GetUpperCase(int length)
        {
            string upperCase = GetLetters(length).ToUpper();
            return upperCase;
        }
        public bool CheckSmallLettersOfAString(string inputString)
        {

            for (int i = 0; i < inputString.Length - 1; i++)
            {
                if (!(char.IsLower(inputString[i]))) 
                    return false;
            }
            return true;
        }
        bool CheckBigLettersOfAString(string inputString)
        {
            return !CheckSmallLettersOfAString(inputString);
        }
    }
}
