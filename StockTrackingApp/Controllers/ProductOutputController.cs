using Microsoft.AspNetCore.Mvc;

namespace StockTrackingApp.Controllers
{
    public class ProductOutputController : Controller
    {
        public IActionResult ProductOutput()
        {
            return View();
        }
    }
}
