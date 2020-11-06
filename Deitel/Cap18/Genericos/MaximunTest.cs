using System;

namespace Cap18.Genericos
{
    public class MaximunTest
    {
        public static void Principal()
        {
            Console.WriteLine($"Maximun of 3, 4 and 5 is {Maximun(3,4,5)}\n");
            Console.WriteLine($"Maximun of 6.6, 8.8 and 7.7 is {Maximun(6.6,8.8,7.7)}\n");
            Console.WriteLine($"Maximun of pear, apple and orange is " +
                $"{Maximun("pear","apple","orange")}\n");
        }
        static T Maximun<T>(T x, T y, T z) where T : IComparable<T>
        {
            var max = x;
            if (y.CompareTo(max) > 0)
            {
                max = y;
            }
            if (z.CompareTo(max) > 0)
            {
                max = z;
            }
            return max;
        }
    }
}