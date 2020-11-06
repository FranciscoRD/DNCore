using System;

namespace Cap11.HerenciaBasica
{
    public class BasePlusCommissionEmployeeTest
    {
        public static void Principal()
        {
            var employee = new BasePlusCommissionEmployee2("Bob","Lewis",
                "333-33-3333",5000.00M,.04M,300.00M);

            Console.WriteLine($"Employee information obtained by properties and methods: \n");
            Console.WriteLine($"First Name is: {employee.FirstName}");
            Console.WriteLine($"Last Name is: {employee.LastName}");
            Console.WriteLine($"Social security number is: {employee.SocialSecurityNumber}");
            Console.WriteLine($"Gross sales are: {employee.GrossSales:C}");
            Console.WriteLine($"Commission rate is: {employee.CommissionRate:F2}");
            Console.WriteLine($"Earnings are: {employee.Earnings():C}");
            Console.WriteLine($"Base salary is: {employee.BaseSalary:C}");

            employee.BaseSalary = 1000.00M;

            Console.WriteLine($"\nUpdated employee information obtained by ToString:\n");
            Console.WriteLine(employee);
            Console.WriteLine($"Earnings: {employee.Earnings():C}");
        }
    }
}