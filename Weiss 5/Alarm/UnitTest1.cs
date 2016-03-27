using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Alarm
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AlarmForMonday()
        {
              var weekDays = Days.Monday ;
            Assert.AreEqual(true, SetAlarmForWeekDays(weekDays,6));
        }
        [Flags]
        enum Days
        {
            Monday = 0x1,
            Tuesday = 0x2,
            Wednesday = 0x4,
            Thursday = 0x8,
            Friday = 0x10,
            Saturday = 0x20,
            Sunday = 0x40
        }
        bool SetAlarmForWeekDays(Days weekDays, int hour)
        {
            return true;
        }
    }
}
