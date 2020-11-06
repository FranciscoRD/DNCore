using System;

namespace Cap13.CustomException
{
    public class SquareRootTest
    {
        public static void Principal()
        {
            var continueLoop = true;

            do
            {
                try
                {
                    Console.Write("Enter a value to calculate the square root of: ");
                    double inputValue = double.Parse(Console.ReadLine());
                    double result = SquareRoot(inputValue);

                    Console.WriteLine($"The square root of {inputValue} is {result:F6}\n");
                    continueLoop = false;
                }
                catch (FormatException formatException)
                {
                    Console.WriteLine("\n" + formatException.Message);
                    Console.WriteLine("Please enter a double value.\n");
                }
                catch(NegativeNumberException negativeNumberException)
                {
                    Console.WriteLine("\n" + negativeNumberException.Message);
                    Console.WriteLine("Please enter a non-negative value.\n");
                }
            } while (continueLoop);
        }
        static double SquareRoot(double value)
        {
            if (value < 0)
            {
                throw new NegativeNumberException("Square root of negative number not permitted");
            }
            else
            {
                return Math.Sqrt(value);
            }
        }
    }
}