using Microsoft.AspNetCore.Mvc;

namespace StockTrackingApp.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {

        [Area("Admin")]
        public IActionResult GetProduct()
        {
            return View();
        }
        [Area("Admin")]
        public IActionResult AddProduct()
        {
            return View();
        }
        [Area("Admin")]
        public IActionResult UpdateProduct()
        {
            return View();
        }
        [Area("Admin")]
        public IActionResult DeleteProduct()
        {
            return View();
        }
    }
}
