using System;

namespace Cap12.Interfaces
{
    public class SalariedEmployee : Employee
    {
        private decimal weeklySalary;

        public SalariedEmployee(string firstName,string lastName,
            string socialSecurityNumber, decimal weeklySalary)
            :base(firstName,lastName,socialSecurityNumber)
        {
            WeeklySalary = weeklySalary;
        }

        public decimal WeeklySalary
        {
            get
            {
                return weeklySalary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value),
                        value,$"{nameof(WeeklySalary)} must be >= 0");
                }
                weeklySalary = value;
            }
        }

        public override decimal Earnings() => WeeklySalary; 

        public override string ToString() => 
            $"Salaried employee: {base.ToString()}\n" +
            $"Weekly Salary: {WeeklySalary:C}";
    }
}