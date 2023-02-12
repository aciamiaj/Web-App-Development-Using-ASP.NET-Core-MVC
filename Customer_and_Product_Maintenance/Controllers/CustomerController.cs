using Lab3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab3.Controllers
{
    public class CustomerController : Controller
    {
        [Route("/Customers")]
        public IActionResult List()
        {
            List<Customer> customer = CustomerDB.GetCustomer();
            return View(customer);
        }

        [Route("/Customer/Details/{customerID}")]
        public IActionResult Details(string customerID)
        {
            Customer customer = CustomerDB.GetCustomer().FirstOrDefault(c => c.CustomerID == customerID);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            if (ModelState.IsValid)
            {
                CustomerDB.GetCustomer().Add(customer);
                return RedirectToAction("List");
            }

            return View(customer);
        }

        [HttpGet]
        [Route("/Customer/Delete/{customerID}")]
        public IActionResult Delete(string customerID)
        {
            Customer selectedCustomer = CustomerDB.GetCustomer().FirstOrDefault(c => c.CustomerID == customerID);
            if (selectedCustomer != null)
            {
                CustomerDB.GetCustomer().Remove(selectedCustomer);
            }

            return RedirectToAction("List");
        }

    }
}
