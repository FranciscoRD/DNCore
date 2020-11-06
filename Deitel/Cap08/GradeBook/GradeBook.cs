using System;

namespace Cap08.GradeBook
{
    public class GradeBook
    {
        private int[] grades;
        public string CourseName { get; }

        public GradeBook(string name, int[] gradesArray)
        {
            grades = gradesArray;
            CourseName = name;
        }

        public void DisplayMessage()
        {
            Console.WriteLine($"Welcome to the grade book for\n{CourseName}!\n");
        }

        public void ProcessGrades()
        {
            OutputGrades();
            Console.WriteLine($"\nClass average is {GetAverage():F}");
            Console.WriteLine($"Lowest grade is: {GetMinimun()}");
            Console.WriteLine($"Highest grade is {GetMaximun()}\n");
            OutputBarChart();
        }

        public int GetMinimun()
        {
            var lowerGrade = grades[0];
            foreach (var grade in grades)
            {
                if (grade < lowerGrade)
                {
                    lowerGrade = grade;
                }
            }
            return lowerGrade;
        }
        public int GetMaximun()
        {
            var highGrade = grades[0];
            foreach (var grade in grades)
            {
                if (grade > highGrade)
                {
                    highGrade = grade;
                }
            }
            return highGrade;
        }
        public double GetAverage()
        {
            var total = 0.0;
            foreach (var grade in grades)
            {
                total += grade;
            }
            return total / grades.Length;
        }
        public void OutputBarChart()
        {
            Console.WriteLine("Grade distribution:");
            var frequency = new int[11];

            foreach (var grade in grades)
            {
                ++frequency[grade/10];
            }
            for (int count = 0; count < frequency.Length; count++)
            {
                if (count == 10)
                {
                    Console.Write("  100: ");
                }
                else
                {
                    Console.Write($"{count*10:D2}-{count*10+9:D2}: ");
                }
                for (int stars = 0; stars < frequency[count]; stars++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public void OutputGrades()
        {
            Console.WriteLine("The grades are:\n");
            for (int student = 0; student < grades.Length; student++)
            {
                Console.WriteLine($"Student {student + 1,2}: {grades[student],3}");
            }
        }
    }
}