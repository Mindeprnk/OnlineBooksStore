using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using OnlineBooksStore.Models;


namespace OnlineBooksStore.ViewModel
{
    public class BookFormViewModel
    {
        public Book Book { get; set; }
        public IEnumerable<Genre> Genres { get; set; }

        public List<Customer> Customers { get; set; }

        public string Title
        {
            get
            {
                if (Book != null && Book.Id != 0)
                    return "Edit Book";
                return "New Book";
            }
        }
    }
}