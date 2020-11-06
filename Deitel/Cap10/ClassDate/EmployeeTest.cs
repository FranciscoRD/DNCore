using System;

namespace Cap10.ClassDate
{
    public class EmployeeTest
    {
        public static void Principal()
        {
            var birthDay = new Date(7,24,1949);
            var hireDate = new Date(3,12,1988);
            var employee = new Employee("Bob","Blue",birthDay, hireDate);

            Console.WriteLine(employee);
        }
    }
}