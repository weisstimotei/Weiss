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
            AlarmConfig[] monday = new AlarmConfig[] { new AlarmConfig(Days.Monday, 8) };
            Assert.IsTrue(CheckAlarm(monday, Days.Monday, 8));
        }
        [TestMethod]
        public void AlarmForTuesdayAndFriday()
        {
            AlarmConfig[] TuesdayAndFriday = new AlarmConfig[] { new AlarmConfig(Days.Tuesday & Days.Friday, 8) };
            Assert.IsFalse(CheckAlarm(TuesdayAndFriday, Days.Tuesday & Days.Friday, 8));
        }
        [TestMethod]
        public void CheckAlarmForWeekend()
        {
            AlarmConfig[] Weekend = new AlarmConfig[] { new AlarmConfig(Days.Sunday, 8) };
            Assert.IsTrue(CheckAlarm(Weekend, Days.Sunday, 8));
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
        struct AlarmConfig
        {
            public Days day;
            public int hour;
            public AlarmConfig(Days weekDays, int hour)
            {
                this.day = weekDays;
                this.hour = hour;
            }
        }
        bool CheckAlarm(AlarmConfig[] alarm, Days day, int hour)
        {
            bool result = false;
            for (int i = 0; i < alarm.Length; i++)
            {
                if (CheckDays(alarm[i].day, day) && CheckHour(alarm[i].hour, hour))
                {
                    result = true;
                }
            }
            return result;
        }
        bool CheckDays(Days day1, Days day2)
        {
            return ((day1 & day2) != 0) ? true : false;
        }
        bool CheckHour(int hour1, int hour2)
        {
            return (hour1 == hour2) ? true : false;
        }
       
    }
}
