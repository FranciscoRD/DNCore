using System;

namespace Cap10.StaticClasses
{
    public class EmployeeTest
    {
        public static void Principal()
        {
            Console.WriteLine($"Employees before instatiation: {Employee.Count}");
            var e1 = new Employee("Susan","Baker");
            var e2 = new Employee("Bob","Blue");

            Console.WriteLine($"\nEmployees after instatiation: {Employee.Count}");

            Console.WriteLine($"\nEmployee 1: {e1.FirstName} {e2.LastName}");
            Console.WriteLine($"\nEmployee 2: {e2.FirstName} {e2.LastName}");

            e1 = null;
            e2 = null;
        }
    }
}