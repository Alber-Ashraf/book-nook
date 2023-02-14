using Microsoft.AspNetCore.Mvc;
using book_nook.Models;

namespace book_nook.Controllers
{
    public class BooksController : Controller
    {
        public ActionResult Random()
        {
            var book = new Book() { Name = "doom" };
            return View(book);
        }
    }
}
