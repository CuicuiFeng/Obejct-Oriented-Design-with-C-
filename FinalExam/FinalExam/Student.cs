using System;
namespace FinalExam
{
    public class Student
    {
        private string _name;

        public Student(string name) => _name = name;

        public void NewBookIsHere(object sender, BookInfoEventArgs b)
        {
            Console.WriteLine($"Dear {_name}: The new book about {b.Book} is arriving.");
        }
    }
}
