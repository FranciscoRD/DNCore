using System;
using System.Text;

namespace Cap16.Builder
{
    public class StringBuilderFeatures
    {
        public static void Principal()
        {
            var buffer = new StringBuilder("Hello, how are you?");

            Console.WriteLine($"buffer = {buffer}" +
                $"\nLength = {buffer.Length}" + 
                $"\nCapacity = {buffer.Capacity}");

            buffer.EnsureCapacity(75);
            Console.WriteLine($"\nNew Capacity = {buffer.Capacity}");

            buffer.Length = 10;
            Console.Write($"New Length = {buffer.Length}\n\nbuffer = ");

            for (int i = 0; i < buffer.Length; i++)
            {
                Console.Write(buffer[i]);
            }
            Console.WriteLine();
        }
    }
}