using System;

namespace Cap16.Miscelaneos
{
    public class StringMethods2
    {
        public static void Principal()
        {
            var string1 = "cheers!";
            var string2 = "GOOD BYE ";
            var string3 = "   spaces   ";

            Console.WriteLine($"string1 = {string1}" +
                $"\nstring2 = {string2}" +
                $"\nstring3 = {string3}");

            Console.WriteLine("\nReplacing 'e' with 'E' in string1: "+
                $"{string1.Replace('e','E')}");

            Console.WriteLine($"\nstring1.ToUpper() = {string1.ToUpper()}" +
                $"\nstring2.ToLower() = {string2.ToLower()}");

            Console.WriteLine($"\nstring3 after trim = {string3.Trim()}");

            Console.WriteLine($"\nstring1 = {string1}");
        }
    }
}