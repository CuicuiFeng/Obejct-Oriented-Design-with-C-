using System;
namespace AssignmentThree
{
    public class Manager:AbstractPerson, IComparable<Manager>
    {

        public int ID { get; set; }
        public int PhoneNumber { get; set; }

        public Manager()
        {
            ID = 001;
            FirstName = "Tracy";
            LastName = "Feng";
            Age = 23;
            PhoneNumber = 617;
        }

        public Manager(int id, string firstName, string lastName, int age, int phoneNumber)
        {
            ID = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            PhoneNumber = phoneNumber;
        }

        int IComparable<Manager>.CompareTo(Manager other)
        {
            return string.Compare(LastName, other.LastName, StringComparison.Ordinal);
        }

        public override string ToString()
        {
            return $"# {ID} {FirstName} {LastName} {Age} . Phone Number is: {PhoneNumber}";
        }
    }
}
