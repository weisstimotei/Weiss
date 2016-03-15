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
        public void TestForGetLetters()
        {
            string a = GetLetters(5);
            string b = GetLowerCase(a);
            Assert.AreEqual(b,a );
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
        string GetLowerCase(string inputString)
        {
            string lowerCase = inputString.ToLower();
            return lowerCase;
        }
        string GetUpperCase(string inputString)
        {
            string upperCase = inputString.ToUpper();
            return upperCase;
        }
    }
}
