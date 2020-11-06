using System;

namespace Cap05.StudentTest
{
    class StudentTest
    {
        static void Principal(string[] args)
        {
            #region Version 1.0
            Student student1 = new Student("Jane Green",93);
            Student student2 = new Student("John Blue",72);

            Console.Write($"{student1.Name}'s letter grade equivalent of ");
            Console.WriteLine($"{student1.Average} is {student1.LetterGrade}");
            Console.Write($"{student2.Name}'s letter grade equivalent of ");
            Console.WriteLine($"{student2.Average} is {student2.LetterGrade}");
            #endregion
        }
    }
}