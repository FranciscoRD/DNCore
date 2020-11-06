using System;
using System.Collections.Generic;

namespace Cap12.Empleado
{
    public class PayrollSystemTest
    {
        public static void Principal()
        {
            var salariedEmployee = new SalariedEmployee("Jonh","Smith",
                "111-11-1111",800.00M);
            var hourlyEmployee = new HourlyEmployee("Karen","Price",
                "222-22-2222",16.75M,40.0M);
            var commissionEmployee = new CommissionEmployee("Sue","Jones",
                "333-33-3333",10000.00M,.06M);
            var basePlusCommissionEmployee = new BasePlusCommissionEmployee(
                "Bob","Lewis","444-44-4444",5000.00M,.04M,300.00M);

            Console.WriteLine("Employees processed individually:\n");

            Console.WriteLine($"{salariedEmployee}\nEarned: " +
                $"{salariedEmployee.Earnings():C}\n");
            Console.WriteLine($"{hourlyEmployee}\nEarned: " +
                $"{hourlyEmployee.Earnings():C}\n");
            Console.WriteLine($"{commissionEmployee}\nEarned: " +
                $"{commissionEmployee.Earnings():C}\n");
            Console.WriteLine($"{basePlusCommissionEmployee}\nEarned: " +
                $"{basePlusCommissionEmployee.Earnings():C}\n");
            
            var employees = new List<Employee>() {salariedEmployee,hourlyEmployee,
                commissionEmployee,basePlusCommissionEmployee};
            
            Console.WriteLine($"Employees processed polymorphically:\n");

            foreach (var currentEmployee in employees)
            {
                Console.WriteLine(currentEmployee);
                if (currentEmployee is BasePlusCommissionEmployee)
                {
                    var employee = (BasePlusCommissionEmployee) currentEmployee;
                    employee.BaseSalary *= 1.10M;
                    Console.WriteLine("new base salary with 10% increase is: " +
                        $"{employee.BaseSalary:C}");
                }
                Console.WriteLine($"Earned: {currentEmployee.Earnings():C}\n");
            }

            for (int j = 0; j < employees.Count; j++)
            {
                Console.WriteLine($"Employee {j} is a {employees[j].GetType()}");
            }
        }
    }
}