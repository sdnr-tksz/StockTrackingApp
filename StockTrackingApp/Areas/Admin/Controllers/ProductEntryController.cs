using Microsoft.AspNetCore.Mvc;

namespace StockTrackingApp.Areas.Admin.Controllers
{
    public class ProductEntryController : Controller
    {
        [Area("Admin")]
        public IActionResult GetProductEntry()
        {
            return View();
        }
        [Area("Admin")]
        public IActionResult ProductEntry()
        {
            return View();
        }
    }
}
