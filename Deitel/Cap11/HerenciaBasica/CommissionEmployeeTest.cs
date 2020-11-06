using System;

namespace Cap11.HerenciaBasica
{
    public class CommissionEmployeeTest
    {
        public static void Principal()
        {
            var employee = new CommissionEmployee("Sue","Jones","222-22-2222",10000.00M,.06M);
            Console.WriteLine("Employee infomation obtained by properties and methods: \n");
            Console.WriteLine($"First Name is: {employee.FirstName}");
            Console.WriteLine($"Last Name is: {employee.LastName}");
            Console.WriteLine($"Social security number is: {employee.SocialSecurityNumber}");
            Console.WriteLine($"Gross sales are: {employee.GrossSales:C}");
            Console.WriteLine($"Commission rate is: {employee.CommissionRate:F2}");
            Console.WriteLine($"Earning are: {employee.Earnings():C}");

            employee.GrossSales = 5000.00M;
            employee.CommissionRate = .1M;

            Console.WriteLine($"\nUpdated employee information obtained by ToString: \n");
            Console.WriteLine($"{employee}");
            Console.WriteLine($"Earnings: {employee.Earnings():C}");
        }
    }
}