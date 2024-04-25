using Microsoft.AspNetCore.Mvc;

namespace StockTrackingApp.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        [Area("Admin")]
        public IActionResult GetCategory()
        {
            return View();
        }
        [Area("Admin")]
        public IActionResult AddCategory()
        {
            return View();
        }
        [Area("Admin")]
        public IActionResult UpdateCategory()
        {
            return View();
        }
        [Area("Admin")]
        public IActionResult DeleteCategory()
        {
            return View();
        }
    }
}
