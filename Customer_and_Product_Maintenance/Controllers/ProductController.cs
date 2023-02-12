using Lab3.Models;
using Microsoft.AspNetCore.Mvc;



namespace Lab3.Controllers
{
    public class ProductController : Controller
    {

        [Route("/Products")]
        public IActionResult List()
        {
            List<Product> products = ProductDB.GetProducts();
            return View(products);
        }

        [Route("/Product/Details/{productCode}")]
        public IActionResult Details(string productCode)
        {
            Product product = ProductDB.GetProducts().FirstOrDefault(p => p.ProductCode == productCode);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                ProductDB.GetProducts().Add(product);
                return RedirectToAction("List");
            }

            return View(product);
        }

        [HttpGet]
        [Route("/Product/Delete/{productCode}")]
        public IActionResult Delete(string productCode)
        {
            Product selectedProduct = ProductDB.GetProducts().FirstOrDefault(p => p.ProductCode == productCode);
            if (selectedProduct != null)
            {
                ProductDB.GetProducts().Remove(selectedProduct);
            }

            return RedirectToAction("List");
        }
    }
}
