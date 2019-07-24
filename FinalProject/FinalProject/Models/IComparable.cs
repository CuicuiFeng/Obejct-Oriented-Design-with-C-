using System;
namespace FinalProject.Models
{
    public interface IComparable<Book>
    {
        int ComparaTo(Book other);
    }
}
