using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

namespace StockTrackingApp.Controllers
{
    public class WarehouseController : Controller
    {
        public IActionResult AddWarehouse()
        {
            var json = System.IO.File.ReadAllText(Server.MapPath("~/Models/iller.json"));
            var iller = JsonConvert.DeserializeObject<List<DistricthViewModel>>(json);

            ViewBag.Iller = new SelectList(iller, "Id", "Name");
            return View();

        }
        public IActionResult UpdateWarehouse()
        {
            return View();
        }
        public IActionResult DeleteWarehouse()
        {
            return View();
        }
    }
}
