using System;
using System.Collections.Generic;

namespace BookManagement.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Classification> Classifications { get; set; }
    }
}
