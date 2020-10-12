using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OnlineBooksStore.Models;
using OnlineBooksStore.ViewModel;


namespace OnlineBooksStore.Controllers
{
    public class BooksController : Controller
    {
        public ViewResult Index()
        {
            var books = GetBooks();

            return View(books);
        }

        private IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book {Id=1,Name="Ramayan"},
                new Book {Id=2,Name="Mahabaratham"}
            };
        }

        public ActionResult Random()
        {
            var book = new Book() { Name = "Ramayan" };

            var customers = new List<Customer>
            {
                new Customer{ Name="Priyanka"},
                new Customer{ Name="Vinay"}
            };

            var viewModel = new RandomBookViewModel
            {
                Book = book,
                Customers = customers

            };
            return View(viewModel);
        }

    }
}