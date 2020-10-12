using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineBooksStore.Models;

namespace OnlineBooksStore.ViewModel
{
    public class RandomBookViewModel
    {
        public Book Book { get; set; }
        public List<Customer> Customers { get; set; }

        public List<Genre> Genres { get; set; }
    }
}