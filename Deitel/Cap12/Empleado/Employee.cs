using System;

namespace Cap12.Empleado
{
    public abstract class Employee
    {
        public string FirstName {get;}
        public string LastName {get;}
        public string SocialSecurityNumber {get;}

        public Employee(string firstName,string lastName, 
            string socialSecurityNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = socialSecurityNumber;
        }

        public override string ToString() =>
            $"{FirstName} {LastName}\n" +
            $"SSN: {SocialSecurityNumber}";

        public abstract decimal Earnings();
    }
}