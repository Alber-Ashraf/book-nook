using Microsoft.AspNetCore.Mvc;
using book_nook.Models;
using book_nook.ViewModels;

namespace book_nook.Controllers
{
    public class BooksController : Controller
    {
        public ActionResult Random()
        {
            var book = new Book() { Name = "doom" };

            var customers = new List<Customer>
            {
                new Customer { Name = "Customer1"},
                new Customer { Name = "Customer2"}
            };

            var viewModel = new RandomBookViewModel()
            {
                Book = book,
                Customers = customers
            };

            return View(viewModel);
        }




        //public ActionResult Edit(int id)
        //{
        //    return Content("id = " + id);
        //}

        //public ActionResult Index(int? id, string str)
        //{
        //    if(!id.HasValue)
        //        id = 0;
        //    if (str == null)
        //        str = "by name";
        //    return Content("id = " + id + " sort by: " + str);
        //}
    }
}
