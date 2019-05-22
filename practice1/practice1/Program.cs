using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace practice1
{
    public class Program
    {
        public static void Main(string[] args) //Program execution begins in Main()
        {
            Person p = new Person();
            Student s = new Student(12,"Ann", "Ann", 3.0);
            Teacher t = new Teacher(32,"Peter", "Daniel", 3000);
        }

    }

    class Person
    {
        protected int age;
        protected string firstName;
        protected string lastName;

        public void setAge(int age)
        {
            this.age = age;
        }

        public int getAge()
        {
            return age;
        }

        public void setFirstName(String s)
        {
            firstName = s;
        }

        public void setLastName(String s)
        {
            lastName = s;
        }

        public Person(int page, string pfirstName, string plastName)
        {
            age = page;
            firstName = pfirstName;
            lastName = plastName;
        }

        public virtual void personPrint()
        {
            Console.WriteLine("Person's age is: {0}", age);
            Console.WriteLine("Person' first name is: {0}", firstName);
            Console.WriteLine("Person's last name is: {0}", lastName);
        }
    }

    class Student : Person
    {
        protected int GPA;

        public Student(int sage, string sfirstName, string slastName, int sGPA)
        {
            age = sage;
            firstName = sfirstName;
            lastName = slastName;
            GPA = sGPA;

        }

        public new void studentPrint()
        {
            Console.WriteLine("Student's age is: {0}", age);
            Console.WriteLine("Student' first name is: {0}", firstName);
            Console.WriteLine("Student's last name is: {0}", lastName);
            Console.WriteLine("Student's GPS is: {0}", GPA);
        }

    }

    public class Teacher : Person
    {
        protected int wage;

        public Teacher(int tage, string tfirstName, string tlastName, int twage)
        {
            age = tage;
            firstName = tfirstName;
            lastName = tlastName;
            wage = twage;
        }

        public new void teachaerPrint()
        {
            Console.WriteLine("Teacher's age is: {0}", age);
            Console.WriteLine("Teacher's first name is: {0}", firstName);
            Console.WriteLine("Teacher's last name is: {0}", lastName);
        }

    }
}
