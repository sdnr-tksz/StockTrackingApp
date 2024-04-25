using Microsoft.AspNetCore.Mvc;

namespace StockTrackingApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult AddProduct()
        {
            return View();
        }
        public IActionResult UpdateProduct()
        {
            return View();
        }
        public IActionResult DeleteProduct()
        {
            return View();
        }
    }
}
