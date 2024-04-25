using Microsoft.AspNetCore.Mvc;

namespace StockTrackingApp.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult SignUp()
        {
            return View();
        }
        public IActionResult SignIn()
        {
            return View();
        }
    }
}