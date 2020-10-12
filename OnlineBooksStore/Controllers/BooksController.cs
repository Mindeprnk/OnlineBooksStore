using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using OnlineBooksStore.Models;
using OnlineBooksStore.ViewModel;


namespace OnlineBooksStore.Controllers
{
    public class BooksController : Controller
    {
        private MyDbContext _context;

        public BooksController()
        {
            _context = new MyDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        } 
        public ViewResult Index()
        {
            var books = _context.Book.Include(b => b.Genre).ToList();

            return View(books);
        }


        //private IEnumerable<Book> GetBooks()
        //{
        //    return new List<Book>
        //    {
        //        new Book {Id=1,Name="Ramayan"},
        //        new Book {Id=2,Name="Mahabaratham"}
        //    };
        //}

            //GET: Movies/Random
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

        public ActionResult Details(int id)
        {
            var book = _context.Book.Include(b => b.Genre).SingleOrDefault(b => b.Id == id);

            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }

    }
}