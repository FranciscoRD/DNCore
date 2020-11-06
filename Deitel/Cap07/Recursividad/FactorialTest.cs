using System;

namespace Cap07.Recursividad
{
    public class FactorialTest
    {
        public static void Principal()
        {
            for (long counter = 0; counter <= 10; ++counter)
            {
                Console.WriteLine($"{counter}! = {Factorial(counter)}");
            }
        }
        static long Factorial(long number)
        {
            if (number <= 1)
            {
                return 1;
            }
            else
            {
                return number * Factorial(number - 1);
            }
        }        
    }
}