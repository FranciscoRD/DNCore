using System;

namespace Cap07.CallSatck
{
    public class Program
    {
        public static void Principal()
        {
            int x = 10;
            Console.WriteLine($"X squared : {Square(x)}");
        }
        static int Square(int y)
        {
            return y * y;
        }
    }
}