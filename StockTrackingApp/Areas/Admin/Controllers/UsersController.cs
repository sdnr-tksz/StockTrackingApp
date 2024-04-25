using Microsoft.AspNetCore.Mvc;

namespace StockTrackingApp.Areas.Admin.Controllers
{
    public class UsersController : Controller
    {
        [Area("Admin")]
        public IActionResult Users()
        {
            return View();
        }
    }
}
