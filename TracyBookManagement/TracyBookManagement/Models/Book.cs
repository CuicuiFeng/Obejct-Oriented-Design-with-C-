using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TracyBookManagement.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
    }
}