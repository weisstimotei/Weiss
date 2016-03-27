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
        [TestMethod]
        public void AlarmForWeekend()
        {
            const Days Days1 = Days.Sunday | Days.Saturday;
            AlarmConfig[] mondayAndWednesday = new AlarmConfig[] { new AlarmConfig(Days1, 8) };
            Assert.IsTrue(CheckAlarm(mondayAndWednesday, Days.Sunday | Days.Saturday, 8));
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
                result = CheckDays(alarm[i].day, day, alarm[i].hour, hour);
            }
            return result;
        }
        bool CheckDays(Days dayConfig, Days dayAlarm, int hourConfig, int hourAlarm)
        {
            return ((dayConfig & dayAlarm) != 0) && (hourConfig == hourAlarm);
        }
         
    }
}
