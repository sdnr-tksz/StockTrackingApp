using Microsoft.AspNetCore.Mvc;

namespace StockTrackingApp.Controllers
{
    public class ProductEntryController : Controller
    {
        public IActionResult ProductEntry()
        {
            return View();
        }
    }
}
