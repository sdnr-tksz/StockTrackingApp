using Microsoft.AspNetCore.Mvc;

namespace StockTrackingApp.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Profile()
        {
            return View();
        }
    }
}
