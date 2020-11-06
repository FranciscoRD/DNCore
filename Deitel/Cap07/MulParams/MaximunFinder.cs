using System;

namespace Cap07.MulParams
{
    public class MaximunFinder
    {
        public static void Principal()
        {
            Console.WriteLine("Enter first floating-point value: ");
            double number1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter second floating-point value: ");
            double number2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter third floating-point value: ");
            double number3 = double.Parse(Console.ReadLine());

            double result = Maximun(number1,number2,number3);

            Console.WriteLine("Maximun is : " + result);
        }
        static double Maximun(double x, double y, double z)
        {
            double maximunValue = x;
            if (y > maximunValue)
            {
                maximunValue = y;
            }
            if (z > maximunValue)
            {
                maximunValue = z;
            }
            return maximunValue;
        }
    }
}