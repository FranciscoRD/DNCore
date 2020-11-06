using System;

namespace Cap18.Genericos
{
    public class GenericMethod
    {
        public static void Principal()
        {
            int[] intArray = {1,2,3,4,5,6};
            double[] doubleArray = {1.1,2.2,3.3,4.4,5.5,6.6};
            char[] charArray = {'H','E','L','L','O'};

            Console.Write("Array intArray Contains: ");
            DisplayArray(intArray);
            Console.Write("Array doubleArray Contains: ");
            DisplayArray(doubleArray);
            Console.Write("Array charArray Contains: ");
            DisplayArray(charArray);
        }
        static void DisplayArray<T> (T[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.Write($"{element}");
            }
            Console.WriteLine();
        }
    }
}