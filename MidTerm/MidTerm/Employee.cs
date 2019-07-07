using System;
namespace MidTerm
{
    public class Employee : Person, IComparable<Person>
    {
        public int EmployeeId { get; set; }
        public double Wage { get; set; }

        public Employee()
        {
            Id = 1;
            Age = 23;
            LastName = "Feng";
            FirstName = "Tracy";
            EmployeeId = 1001;
            Wage = 26;
        }

        public Employee(int id, int age, string firstName, string lastName, int employeeId, double wage)
        {
            Id = id;
            Age = age;
            LastName = lastName;
            FirstName = firstName;
            EmployeeId = employeeId;
            Wage = wage;
        }

        int IComparable<Person>.CompareTo(Person other)
        {
            return string.Compare(LastName, other.LastName, StringComparison.Ordinal);
        }

        public override string ToString()
        {
            return $"# {Id} : {FirstName} {LastName}, age : {Age}, wage : {Wage}";
        }
    }
}
