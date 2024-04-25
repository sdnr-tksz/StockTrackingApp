using Microsoft.AspNetCore.Mvc;

namespace StockTrackingApp.Areas.Admin.Controllers
{
    public class RegisterController : Controller
    {
        [Area("Admin")]
        public IActionResult Register()
        {
            return View();
        }
    }
}
