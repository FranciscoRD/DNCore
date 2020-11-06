using System;

namespace Cap16.Constructor
{
    public class StringConstructor
    {
        public static void Principal()
        {
            char[] characterArray = {'b','i','r','t','h',' ','d','a','y'};
            var originalString = "Welcome to C# programming!";
            var string1 = originalString;
            var string2 = new string(characterArray);
            var string3 = new string(characterArray,6,3);
            var string4 = new string('C',5);

            Console.WriteLine($"string1 = \"{string1}\"\n" + 
                $"string2 = \"{string2}\"\n" +
                $"string2 = \"{string3}\"\n" +
                $"string2 = \"{string4}\"\n");
        }
    }
}