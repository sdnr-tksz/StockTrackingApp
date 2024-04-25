using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StockTrackingServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductEntryServiceController : ControllerBase
    {
        [HttpPost]
        [Route("SaveProductEntry")]
        public IActionResult SaveProductEntry(ProductEntry productEntry)
        {
            using (var context = new Context())
            {
                var repository = new GenericRepositoryController<ProductEntry>(context);
                repository.Save(productEntry);
            }

            return Ok("Data inserted.");
        }

        [HttpPost]
        [Route("DeleteProductEntry")]
        public IActionResult DeleteProductEntry(ProductEntry productEntry)
        {
            using (var context = new Context())
            {
                var repository = new GenericRepositoryController<ProductEntry>(context);
                repository.Delete(productEntry);
            }

            return Ok("Data deleted.");
        }

        [HttpPost]
        [Route("UpdateProductEntry")]
        public IActionResult UpdateProductEntry(ProductEntry productEntry)
        {
            using (var context = new Context())
            {
                var repository = new GenericRepositoryController<ProductEntry>(context);
                repository.Update(productEntry);
            }

            return Ok("Data updated.");
        }
    }
}
