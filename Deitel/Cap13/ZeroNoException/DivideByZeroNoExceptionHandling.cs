using System;

namespace Cap13.ZeroNoException
{
    public class DivideByZeroNoExceptionHandling
    {
        public static void Principal()
        {
            Console.Write("Please enter an Integer numerator: ");
            var numerator = int.Parse(Console.ReadLine());

            Console.Write("Please enter an integer denominator: ");
            var denominator = int.Parse(Console.ReadLine());

            var result = numerator / denominator;
            Console.WriteLine($"\nResult: {numerator} / {denominator} = {result}");
        }
    }
}