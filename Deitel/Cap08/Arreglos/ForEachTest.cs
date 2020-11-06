using System;

namespace Cap08.Arreglos
{
    public class ForEachTest
    {
        public static void Principal()
        {
            int[] array = {87,68,94,100,83,78,85,91,76,87};
            int total = 0;

            foreach (var number in array)
            {
                total += number;
            }
            Console.WriteLine($"Total of array elements: {total}");
        }
    }
}