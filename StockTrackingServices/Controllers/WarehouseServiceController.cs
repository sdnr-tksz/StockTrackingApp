using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StockTrackingServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WarehouseServiceController : ControllerBase
    {
        [HttpPost]
        [Route("SaveWarehouse")]
        public IActionResult SaveWarehouse(Warehouse saveWarehouse)
        {
            using (var context = new Context())
            {
                var repository = new GenericRepositoryController<Warehouse>(context);
                repository.Save(saveWarehouse);
            }

            return Ok("Warehouse saved.");
        }

        [HttpPost]
        [Route("DeleteWarehouse")]
        public IActionResult DeleteWarehouse(Warehouse deleteWarehouse)
        {
            using (var context = new Context())
            {
                var repository = new GenericRepositoryController<Warehouse>(context);
                repository.Delete(deleteWarehouse);
            }

            return Ok("Warehouse deleted.");
        }

        [HttpPost]
        [Route("UpdateWarehouse")]
        public IActionResult UpdateWarehouse(Warehouse updatedWarehouse)
        {
            using (var context = new Context())
            {
                var repository = new GenericRepositoryController<Warehouse>(context);
                repository.Update(updatedWarehouse);
            }

            return Ok("Warehouse updated.");
        }
    }
}
