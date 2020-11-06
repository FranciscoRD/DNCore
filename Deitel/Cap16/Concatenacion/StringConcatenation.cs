using System;

namespace Cap16.Concatenacion
{
    public class StringConcatenation
    {
        public static void Principal()
        {
            var string1 = "Happy ";
            var string2 = "Birthday";

            Console.WriteLine($"string1 = {string1}");
            Console.WriteLine($"string2 = {string2}");
            Console.WriteLine($"Result of string.Concat(string1, string2) = " +
                $"{string.Concat(string1,string2)}");
            Console.WriteLine($"string after concatenation = {string1}");
        }
    }
}