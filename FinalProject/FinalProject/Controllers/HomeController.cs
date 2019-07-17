using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FinalProject.Models;

namespace FinalProject.Controllers
{
    public class HomeController : Controller
    {
        private List<Book> books = new List<Book>
        {
            new Book {Id = 1, Name = "Your Name", Genre = "fiction", Author = "Makoto Shinkai"},
            new Book {Id = 2, Name = "TOEFL OG", Genre = "teaching material", Author = "Anna"},
        };

        public IActionResult Index()
        {
            return View(books);
        }

        public IActionResult Display()
        {
            return View();
        }

        public IActionResult Detaile(int id)
        {
            Book book = books.Find(b => b.Id == id);
            return View(book);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
