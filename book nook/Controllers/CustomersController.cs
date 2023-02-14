using book_nook.Models;
using book_nook.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace book_nook.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Customers()
        {
            var customers = new List<Customer>
            {
                new Customer { Name = "Alber"},
                new Customer { Name = "Bero"}
            };

            var viewModel = new CustomerViewModel()
            {
                Customers = customers
            };


            return View(viewModel);
        }
    }
}
