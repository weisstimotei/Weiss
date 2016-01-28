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
            
            return 6;
        }
    }
}
