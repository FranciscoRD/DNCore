using System;

namespace Cap16.Comparacion
{
    public class StringStartEnd
    {
        public static void Principal()
        {
            string[] strings = {"started","starting","ended","ending"};

            foreach (var element in strings)
            {
                if (element.StartsWith("st"))
                {
                    Console.WriteLine($"\"{element}\" starts with \"st\"");
                }
            }

            Console.WriteLine();

            foreach (var element in strings)
            {
                if (element.EndsWith("ed"))
                {
                    Console.WriteLine($"\"{element}\" ends with \"ed\"");
                }
            }
            Console.WriteLine();
        }
    }
}