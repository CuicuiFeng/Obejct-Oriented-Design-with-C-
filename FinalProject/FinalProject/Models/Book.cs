using System;
using Microsoft.AspNetCore.Identity;

namespace FinalProject.Models
{
    public class Book: IComparable<Book>
    {
        public Book()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        public int ComparaTo(Book other)
        {
            return other.Price.CompareTo(this.Price);
        }

        public Book(int id, string name, string genre, string author, double price, string description)
        {
            this.Id = id;
            this.Name = name;
            this.Genre = genre;
            this.Author = author;
            this.Price = price;
            this.Description = description;
        }

        public Book(int id)
        {
            this.Id = id;
        }

        internal static int CompareTo(Book b1, Book b2)
        {
            return b1.Price.CompareTo(b2.Price);
        }
    }
}