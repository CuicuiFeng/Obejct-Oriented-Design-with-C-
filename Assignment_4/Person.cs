using System;
namespace MidTerm
{
    public class Person : AbstractPerson, IComparable<Person>
    {
        public Person()
        {
        }

        public bool IsEmployed { get; set; }
       
        public Person(int id, int age, string firstName, string lastName)
        {
            Id = id;
            Age = age;
            FirstName = firstName;
            LastName = lastName;
        }

        public int CompareTo(Person other)
        {
            return string.Compare(LastName, other.LastName, StringComparison.Ordinal);
        }

        //public static int CompareByID(Person p1, Person p2)
        //{
        //    return p1.Id.CompareTo(p2.Id);
        //}

        //public static int CompareByAge(Person p1, Person p2)
        //{
        //    return p1.Age.CompareTo(p2.Age);
        //}

        //public static int CompareByFirstName(Person p1, Person p2)
        //{
        //    return string.Compare(p1.FirstName, p2.FirstName);
        //}

        //public static int CompareByLasttName(Person p1, Person p2)
        //{
        //    return string.Compare(p1.LastName, p2.LastName);
        //}

        public static Comparison<AbstractPerson> CompareByID = delegate (AbstractPerson p1, AbstractPerson p2)
        {
            return p1.Id.CompareTo(p2.Id);
        };

        public static Comparison<AbstractPerson> CompareAge = delegate (AbstractPerson p1, AbstractPerson p2)
        {
            return p1.Age.CompareTo(p2.Age);
        };

        public static Comparison<AbstractPerson> CompareByFirstName = delegate (AbstractPerson p1, AbstractPerson p2)
        {
            return string.Compare(p1.FirstName, p2.FirstName);
        };

        public static Comparison<AbstractPerson> CompareByLastName = delegate (AbstractPerson p1, AbstractPerson p2)
        {
            return string.Compare(p1.LastName, p2.LastName);
        };


        public override string ToString()
        {
            return $"# {Id} : {FirstName} {LastName}, age : {Age} ";
        }
    }
}
