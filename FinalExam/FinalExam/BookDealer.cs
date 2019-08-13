using System;
namespace FinalExam
{
    public class BookDealer
    {
        // BookDealer Event Publisher
        public event EventHandler<BookInfoEventArgs> NewBookInfo;

        public void NewBook(string book)
        {
            NewBookInfo?.Invoke(this, new BookInfoEventArgs(book));
        }
    }
}
