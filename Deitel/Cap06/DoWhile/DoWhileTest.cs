using System;

namespace Cap06.DoWhile
{
    public class DoWhileTest
    {
        public static void Principal()
        {
            int counter = 1;
            do
            {
                Console.Write($"{counter} ");
                ++counter;
            } while (counter <= 10);
        }
    }
}