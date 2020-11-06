using System;
namespace Cap05.Average
{
    public class ClassAverage
    {
        public static void Principal(string[] args)
        {
            #region Version 2.0
            /* */
            int total = 0;
            int gradeCounter = 0;

            Console.Write("Enter grade or -1 to quit: ");
            int grade = int.Parse(Console.ReadLine());

            while (grade != -1)
            {
                total = total + grade;
                gradeCounter = gradeCounter + 1;
                Console.Write("Enter grade or -1 to quit: ");
                grade = int.Parse(Console.ReadLine());
            }
            if (gradeCounter != 0)
            {
                double average = (double)total/gradeCounter;
                Console.WriteLine($"\nTotal of the {gradeCounter} grades entered is {total}");
                Console.WriteLine($"Class average is {average:F}");
            }
            else
            {
                Console.WriteLine("No grades were entered");
            }
            /* */
            #endregion

            #region Version 1.0
            /*
            int total = 0;
            int gradeCounter = 1;

            while (gradeCounter <= 10)
            {
                Console.Write("Enter grade: ");
                int grade = int.Parse(Console.ReadLine());
                total = total +grade;
                gradeCounter = gradeCounter+1;
            }
            int average = total/10;

            Console.WriteLine($"\nTotal of all 10 grades is {total}");
            Console.WriteLine($"Class average is {average}");
            */
            #endregion
        }
    }
}