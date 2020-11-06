using System;

namespace Cap08.Arreglos
{
    public class RollDie
    {
        public static void Principal()
        {
            var randomNumbers = new Random();
            var frequency = new int[7];

            for (var roll = 1; roll < 1000; roll++)
            {
                ++frequency[randomNumbers.Next(1,7)];
            }

            Console.WriteLine($"{"Face"}{"Frequency",10}");

            for (var face = 1; face < frequency.Length; face++)
            {
                Console.WriteLine($"{face+":",4}{frequency[face],10}");
            }
        }
    }
}