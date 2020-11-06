using System;

namespace Cap10.TimeClass
{
    public class Time1Test
    {
        public static void Principal()
        {
            var time = new Time1();

            Console.WriteLine($"The initial universal time is: {time.ToUniversalString()}");
            Console.WriteLine($"The initial standar time is: {time.ToString()}");
            Console.WriteLine();

            time.SetTime(13,27,6);
            
            Console.WriteLine($"Universal time after SetTime is: {time.ToUniversalString()}");
            Console.WriteLine($"Standar time after SetTime is: {time.ToString()}");
            Console.WriteLine();

            try
            {
                time.SetTime(99,99,99);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message + "\n");
            }

            Console.WriteLine("After attempting invalid setting");
            Console.WriteLine($"Universal time is: {time.ToUniversalString()}");
            Console.WriteLine($"Standar time is: {time.ToString()}");
        }
    }
}