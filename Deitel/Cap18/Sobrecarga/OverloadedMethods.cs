using System;

namespace Cap18.Sobrecarga
{
    public class OverloadedMethods
    {
        public static void Principal()
        {
            int[] intArray = {1,2,3,4,5,6};
            double[] doubleArray = {1.1,2.2,3.3,4.4,5.5,6.6,7.7};
            char[] charArray = {'H','E','L','L','O'};

            Console.Write("Array intArray contains: ");
            DisplayArray(intArray);
            Console.Write("Array doubleArray contains: ");
            DisplayArray(doubleArray);
            Console.Write("Array charArray contains: ");
            DisplayArray(charArray);
        }
        static void DisplayArray(int[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.Write($"{element}");
            }
            Console.WriteLine();
        }
        static void DisplayArray(double[] doubleArray)
        {
            foreach (var element in doubleArray)
            {
                Console.Write($"{element}");
            }
            Console.WriteLine();
        }
        static void DisplayArray(char[] charArray)
        {
            foreach (var element in charArray)
            {
                Console.Write($"{element}");
            }
            Console.WriteLine();
        }
    }
}