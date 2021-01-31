using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult CustomersList()
        {
            var customers = GetCustomers();
            return View(customers);
        }

        [Route("customers/details/{id:range(1,2)}")]
        public ActionResult Details(int id)
        {
            var customer = GetCustomers().SingleOrDefault(c=>c.Id==id);
            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        private IEnumerable<Customers> GetCustomers()
        {

            return new List<Customers>{
                new Customers { Id = 1, Name="Ted Mosby" },
                new Customers { Id = 2, Name = "Barney Stinson" }
            };
            
        }
    }
}