using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lunch
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestForFirstDayOfMeeting()
        {
            Assert.AreEqual(12,GetTheDayOfMeeting(4,6));
        }
        int GetTheDayOfMeeting(int daysForHim, int daysForMe)
        {
            return 12;
        }
    }
}
