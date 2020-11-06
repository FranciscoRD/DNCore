using System;

namespace Cap08.Arreglos
{
    public class InitArray
    {
        public static void First()
        {
            int[] array = new int[5];
            Console.WriteLine($"{"Index"}{"Value",8}");

            for (int counter = 0; counter < array.Length; counter++)
            {
                Console.WriteLine($"{counter,5}{array[counter],8}");
            }
        }
        public static void Second()
        {
            int[] array = {32,27,64,18,95};
            Console.WriteLine($"{"Index"}{"Value",8}");

            for (int counter = 0; counter < array.Length; counter++)
            {
                Console.WriteLine($"{counter,5}{array[counter],8}");
            }
        }
        public static void Third()
        {
            const int ArrayLength = 5;
            int[] array = new int[ArrayLength];

            for (int counter = 0; counter < array.Length; counter++)
            {
                array[counter] = 2+2 * counter;
            }

            Console.WriteLine($"{"Index"}{"Counter",8}");

            for (int counter = 0; counter < array.Length; counter++)
            {
                Console.WriteLine($"{counter,5}{array[counter],8}");
            }
        }
    }
}