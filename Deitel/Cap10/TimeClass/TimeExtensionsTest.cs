using System;

namespace Cap10.TimeClass
{
    public class TimeExtensionsTest
    {
        public static void Principal()
        {
            var myTime = new Time2();
            myTime.SetTime(11,34,15);

            Console.Write("Use the DisplayTime extension method: ");
            myTime.DisplayTime();

            Console.Write("Add 15 hours with the AddHours extension method: ");
            myTime.AddHours(15).DisplayTime();

            Console.Write("Use fully qualified extension-method name: ");
            TimeExtensions.DisplayTime(myTime);
        }
    }
}