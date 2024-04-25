using Microsoft.AspNetCore.Mvc;

namespace StockTrackingApp.Areas.Admin.Controllers
{
    public class ProductOutputController : Controller
    {
        [Area("Admin")]
        public IActionResult GetProductOutput()
        {
            return View();
        }
        [Area("Admin")]
        public IActionResult ProductOutput()
        {
            return View();
        }
    }
}
