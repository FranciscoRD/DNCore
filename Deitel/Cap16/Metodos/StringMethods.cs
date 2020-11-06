using System;

namespace Cap16.Metodos
{
    public class StringMethods
    {
        public static void Principal()
        {
            var string1 = "hello there";
            var characterArray = new char[5];

            Console.WriteLine($"string1: \"{string1}\"");

            Console.WriteLine($"Legth of string1: {string1.Length}");

            Console.Write("The string reversed is: ");
            for (int i = string1.Length - 1 ; i >= 0; --i)
            {
                Console.Write(string1[i]);
            }

            string1.CopyTo(0,characterArray,0,characterArray.Length);
            Console.Write("\nThe character array is: ");
            foreach (var element in characterArray)
            {
                Console.Write(element);
            }
            Console.WriteLine("\n");
        }
    }
}