using System;

namespace BookManagement.Models
{
    public class Classification
    {
        public int Genreid { get; set; }
        public string Genre { get; set; }

        public virtual Book Book { get; set; }
    }
}
