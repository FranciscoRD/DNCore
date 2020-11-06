using System;
using System.Text;

namespace Cap16.Builder
{
    public class StringBuilderReplace
    {
        public static void Principal()
        {
            var builder1 = new StringBuilder("Happy Birthday Jane");
            var builder2 = new StringBuilder("goodbye greg");

            Console.WriteLine($"Before replacements : \n{builder1}\n{builder2}");

            builder1.Replace("Jane","Greg");
            builder2.Replace('g','G',0,5);

            Console.WriteLine($"\nAfter replacements: \n{builder1}\n{builder2}");
        }
    }
}