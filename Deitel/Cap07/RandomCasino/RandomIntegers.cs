using System;

namespace Cap07.RandomCasino
{
    public class RandomIntegers
    {
        public static void Principal()
        {
            Random randomNumbers = new Random();

            for (int counter = 1; counter <= 20; counter++)
            {
                int face = randomNumbers.Next(1,7);
                Console.Write($"{face} ");
            }
        }
    }
}