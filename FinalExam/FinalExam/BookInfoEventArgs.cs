using System;

namespace FinalExam
{
    public class BookInfoEventArgs: EventArgs
    {
        public BookInfoEventArgs(string book)
            => Book = book;
        public string Book { get; }
    }
}
