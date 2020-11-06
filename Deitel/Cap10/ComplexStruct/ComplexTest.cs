using System;

namespace Cap10.ComplexStruct
{
    public class ComplexTest
    {
        public static void Principal()
        {
            Console.Write("Enter the real part of complex number x: ");
            double realPart = double.Parse(Console.ReadLine());

            Console.Write("Enter the imaginary part of complex number x: ");
            double imaginaryPart = double.Parse(Console.ReadLine());

            var x = new ComplexNumber(realPart, imaginaryPart);

            Console.Write("\nEnter the Real part of complex number y: ");
            realPart = double.Parse(Console.ReadLine());

            Console.Write("Enter the imaginary part of complex number y: ");
            imaginaryPart = double.Parse(Console.ReadLine());

            var y = new ComplexNumber(realPart,imaginaryPart);

            Console.WriteLine();

            Console.WriteLine($"{x} + {y} = {x + y}");
            Console.WriteLine($"{x} - {y} = {x - y}");
            Console.WriteLine($"{x} * {y} = {x * y}");
        }
    }
}