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
              Assert.AreEqual(true, CheckAlarmForWeekDays(weekDays, 6));
        }
        [TestMethod]
        public void AlarmForTuesdayAndFriday()
        {
              Assert.AreEqual(true, CheckAlarmForWeekDays(Days.Tuesday & Days.Friday, 6));
        }
        [TestMethod]
        public void CheckAlarmForWeekend()
        {
            Assert.AreEqual(false, CheckAlarmForWeekDays(Days.Sunday, 5));
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
        bool CheckAlarmForWeekDays(Days weekDay,int hour)
        {
            var dayToCheck = Days.Monday | Days.Tuesday | Days.Wednesday | Days.Thursday | Days.Friday ;
            bool testDay = (dayToCheck & weekDay) == weekDay;
            return testDay;
          }
    }
}
