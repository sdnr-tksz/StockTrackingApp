using Microsoft.AspNetCore.Mvc;

namespace StockTrackingApp.Areas.Admin.Controllers
{
    public class WarehouseController : Controller
    {

        [Area("Admin")]
        public IActionResult GetWarehouse()
        {
            return View();
        }
        [Area("Admin")]
        public IActionResult AddWarehouse()
        {
            return View();
        }
        [Area("Admin")]
        public IActionResult UpdateWarehouse()
        {
            return View();
        }
        [Area("Admin")]
        public IActionResult DeleteWarehouse()
        {
            return View();
        }
    }
}
