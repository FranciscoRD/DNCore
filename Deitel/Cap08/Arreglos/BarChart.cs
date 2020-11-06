using System;

namespace Cap08.Arreglos
{
    public class BarChart
    {
        public static void Principal()
        {
            int[] array ={0,0,0,0,0,0,1,2,4,2,1};
            Console.WriteLine("Grade distribution");

            for (var counter = 0; counter < array.Length; counter++)
            {
                if (counter == 10)
                {
                    Console.Write("  100: ");
                }
                else
                {
                    Console.Write($"{counter * 10:D2}-{counter*10+9:D2}: ");
                }
                for (int stars = 0; stars < array[counter]; stars++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}