namespace Cap09.QueryingEmployee
{
    public class Employee
    {
        public string FirstName { get; }
        public string LastName { get; }
        private decimal monthlySalary;

        public Employee(string firtsName, string lastName, decimal salary)
        {
            FirstName = firtsName;
            LastName = lastName;
            MonthlySalary = salary;
        }

        public decimal MonthlySalary
        {
            get
            {
                return monthlySalary;
            }
            set
            {
                if (value >= 0M)
                {
                    monthlySalary = value;
                }
            }
        }

        public override string ToString() => $"{FirstName,-10} {LastName,-10} {MonthlySalary,10:C}";
    }
}