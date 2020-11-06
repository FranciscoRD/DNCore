using System;

namespace Cap16.Subcadenas
{
    public class Substring
    {
        public static void Principal()
        {
            var letters = "abcdefghijklmabcdefghijklm";

            Console.WriteLine("Substring from index 20 to end is " +
                $"\"{letters.Substring(20)}\"");

            Console.WriteLine("Substring from index 0 of legth 6 is " +  
                $"\"{letters.Substring(0,6)}\"");
        }
    }
}