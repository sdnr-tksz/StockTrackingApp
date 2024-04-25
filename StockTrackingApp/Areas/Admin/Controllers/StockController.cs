using Microsoft.AspNetCore.Mvc;

namespace StockTrackingApp.Areas.Admin.Controllers
{
    public class StockController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
