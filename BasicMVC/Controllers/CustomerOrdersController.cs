using BasicMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace BasicMVC.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            var customer = new Customer
            {
                Id = 1,
                FirstName = "Emre",
                LastName = "Şekerci",
                Email = "emresekerci@windowslive.com"
            };
            var orders = new List<Order>
            {
                new Order { Id = 101, ProductName = "Laptop", Price = 1500.00M, Quantity = 1 },
                new Order { Id = 102, ProductName = "Mouse", Price = 20.00M, Quantity = 2 },
                new Order { Id = 103, ProductName = "Keyboard", Price = 50.00M, Quantity = 1 }
            };
            var viewModel = new CustomerOrderViewModel
            {
                Customer = customer,
                Orders = orders
            };
            return View(viewModel);

        }
    }
}
