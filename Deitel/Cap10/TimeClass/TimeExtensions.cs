using System;

namespace Cap10.TimeClass
{
    static class TimeExtensions
    {
        public static void DisplayTime(this Time2 aTime)
        {
            Console.WriteLine(aTime.ToString());
        }
        public static Time2 AddHours(this Time2 aTime,int hours)
        {
            var newTime = new Time2(){Minute = aTime.Minute, Second = aTime.Second};
            newTime.Hour = (aTime.Hour + hours) % 24;
            return newTime;
        }
    }
}