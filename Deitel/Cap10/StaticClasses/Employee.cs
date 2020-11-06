using System;

namespace Cap10.StaticClasses
{
    public class Employee
    {
        public static int Count { get; private set; }
        public string FirstName { get; }
        public string LastName { get; }

        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            ++Count;
            Console.WriteLine("Employee constructor: "+
                $"{FirstName} {LastName}; Count = {Count}");
        }
    }
}