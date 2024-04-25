using Microsoft.AspNetCore.Mvc;

namespace StockTrackingApp.Areas.Admin.Controllers
{
    public class ProfileController : Controller
    {
        [Area("Admin")]
        public IActionResult Profile()
        {
            return View();
        }
    }
}
