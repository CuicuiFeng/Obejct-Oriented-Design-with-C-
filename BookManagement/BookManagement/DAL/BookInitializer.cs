using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using BookManagement.Models;

namespace BookManagement.DAL
{
    public class BookInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<BookContext>
    {
        protected override void Seed(BookContext context)
        {
            var books = new List<Book>
            {
            new Book {Id = 1, Name = "Your Name",Author = "Makoto Shinkai", Price = 19.99, Description ="High school girl Mitsuha Miyamizu lives in the fictional town of Itomori in Japan's mountainous Hida region. She is bored with the country life, and wishes to be a handsome boy in her next life. She begins switching bodies intermittently with Taki Tachibana, a high school boy in Tokyo, when they wake up."},
            new Book {Id = 2, Name = "TOEFL Official Guide", Author = "Anna", Price = 39.99, Description = "This book from ETS contains five more retired TOEFL® test forms with authentic reading, listening, speaking, and writing questions, plus an answer key for each form. This third edition reflects the all the latest changes and updates to the test. "},
            };

            books.ForEach(s => context.Books.Add(s));
            context.SaveChanges();

            var classifications = new List<Classification>
            {
            new Classification{Genreid=0001,Genre="Novel"},
            new Classification{Genreid=0002,Genre="Comic"},
            new Classification{Genreid=0003,Genre="Teaching"},
            };
            classifications.ForEach(s => context.Classifications.Add(s));
            context.SaveChanges();

        }
    }
}