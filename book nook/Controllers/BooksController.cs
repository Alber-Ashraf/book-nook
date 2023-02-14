using Microsoft.AspNetCore.Mvc;
using book_nook.Models;
using book_nook.ViewModels;

namespace book_nook.Controllers
{
    public class BooksController : Controller
    {
        public ActionResult Index()
        {
            var books = new List<Book>
            {
                new Book { Name = "Doom"},
                new Book { Name = "Death"}
            };

            var viewModel = new BookViewModel()
            {
                Books = books
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
