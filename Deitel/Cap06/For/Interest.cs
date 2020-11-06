using System;
namespace Cap06.For
{
    public class Interest
    {
        public static void Principal()
        {
            decimal principal= 1000;
            double rate = 0.05;

            Console.WriteLine("Year   Amount on deposit");
            for (int year = 1; year <= 10; year++)
            {
                decimal amount = principal * ((decimal)Math.Pow(1.0 + rate, year));
                Console.WriteLine($"{year,4}{amount,20:C}");
            }
        }
    }
}