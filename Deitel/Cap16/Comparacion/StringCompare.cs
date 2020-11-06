using System;

namespace Cap16.Comparacion
{
    public class StringCompare
    {
        public static void Principal()
        {
            var string1 = "hello";
            var string2 = "good bye";
            var string3 = "Happy Birthday";
            var string4 = "happy birthday";

            Console.WriteLine($"string1 = \"{string1}\"\n" + 
                $"string2 = \"{string2}\"\n" +
                $"string2 = \"{string3}\"\n" +
                $"string2 = \"{string4}\"\n");
            
            if (string1.Equals("hello"))
            {
                Console.WriteLine("string1 equals \"hello\"");
            }
            else
            {
                Console.WriteLine("string1 does not equal \"hello\"");
            }

            if (string1 == "hello")
            {
                Console.WriteLine("string1 equals \"hello\"");
            }
            else
            {
                Console.WriteLine("string1 does not equal \"hello\"");
            }

            if (string.Equals(string3,string4))
            {
                Console.WriteLine("string3 equals string4");
            }
            else
            {
                Console.WriteLine("string3 does not equal string4");
            }

            Console.WriteLine($"\nstring1.CompareTo(string2) is {string1.CompareTo(string2)}");
            Console.WriteLine($"\nstring2.CompareTo(string1) is {string2.CompareTo(string1)}");
            Console.WriteLine($"\nstring1.CompareTo(string1) is {string1.CompareTo(string1)}");
            Console.WriteLine($"\nstring3.CompareTo(string4) is {string3.CompareTo(string4)}");
            Console.WriteLine($"\nstring4.CompareTo(string3) is {string4.CompareTo(string3)}");
        }
    }
}