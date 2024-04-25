using Microsoft.AspNetCore.Mvc;

namespace StockTrackingApp.Areas.Admin.Controllers
{
    public class BrandController : Controller
    {
        [Area("Admin")]
        public IActionResult GetBrand()
        {
            return View();
        }
        [Area("Admin")]
        public IActionResult AddBrand()
        {
            return View();
        }
        [Area("Admin")]
        public IActionResult UpdateBrand()
        {
            return View();
        }
        [Area("Admin")]
        public IActionResult DeleteBrand()
        {
            return View();
        }
    }
}
