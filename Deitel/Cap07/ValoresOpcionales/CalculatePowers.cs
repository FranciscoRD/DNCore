using System;

namespace Cap07.ValoresOpcionales
{
    public class CalculatePowers
    {
        public static void Principal()
        {
            Console.WriteLine($"Power(10): {Power(10)}");
            Console.WriteLine($"Power(2,10): {Power(2,10)}");
        }
        static int Power(int baseValue, int exponentValue = 2)
        {
            int result = 1;
            for (int i = 1; i < exponentValue; ++i)
            {
                result *= baseValue;
            }
            return result;
        }
    }
}