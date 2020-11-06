using System;

namespace Cap05
{
    public class Analysis
    {
        static void Principal(string[] args)
        {
            int passes = 0;
            int failures = 0;
            int studentCounter = 1;

            while (studentCounter <= 10)
            {
                Console.Write("Enter result (1 = pass, 2 = fails): ");
                int result = int.Parse(Console.ReadLine());

                if (result == 1)
                {
                    passes++;
                }
                else
                {
                    failures ++;
                }
                studentCounter++;
            }
            Console.WriteLine($"Passed: {passes}\nFailed: {failures}");
            if (passes > 8)
            {
                Console.WriteLine("Bonus to instructor!");
            }
        }
    }
}