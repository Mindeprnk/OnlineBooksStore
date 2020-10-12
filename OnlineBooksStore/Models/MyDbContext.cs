using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace OnlineBooksStore.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Book> Book { get; set; }
    }
}