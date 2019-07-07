using System;
namespace MidTerm
{
    public class Person : AbstractPerson, IComparable<Person>
    {
        public Person()
        {
        }

        public Boolean IsEmployed { get; set; }
       

        public Person(int id, int age, string firstName, string lastName)
        {
            Id = id;
            Age = age;
            FirstName = firstName;
            LastName = lastName;
        }

        int IComparable<Person>.CompareTo(Person other)
        {
            return string.Compare(LastName, other.LastName, StringComparison.Ordinal);
        }

        //public static int SortById(Person p1, Person p2)
        //{
        //    return p1.Id.CompareTo(p2.Id);
        //}

        //public static int SortByAge(Person p1, Person p2)
        //{
        //    return p1.Age.CompareTo(p2.Age);
        //}

        //public static int SortByFirstName(Person p1, Person p2)
        //{
        //    return string.Compare(p1.FirstName, p2.FirstName, StringComparison.Ordinal);
        //}

        public override string ToString()
        {
            return $"# {Id} : {FirstName} {LastName}, age : {Age} ";
        }
    }
}
