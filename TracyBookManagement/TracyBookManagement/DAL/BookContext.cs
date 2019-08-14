using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TracyBookManagement.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace TracyBookManagement.DAL
{
    public class BookContext : DbContext
    { 
        public BookContext() : base("BookContext")
        {
        }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}