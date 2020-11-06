using System;

namespace Cap10.TimeClass
{
    public class ThisTest
    {
        public static void Principal()
        {
            var time = new SimpleTime(15,30,19);
            Console.WriteLine(time.BuildString());
        }
    }
}