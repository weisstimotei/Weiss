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
            return GetCMMMC(ref daysForHim, ref daysForMe);
        }

        private static int GetCMMMC(ref int daysForHim, ref int daysForMe)
        {
            int product = daysForHim * daysForMe;
            while (daysForHim != daysForMe)
            {
                if (daysForHim > daysForMe)
                    daysForHim = daysForHim - daysForMe;
                else
                    daysForMe = daysForMe - daysForHim;
            }

            return product / daysForHim;
        }
    }
}
