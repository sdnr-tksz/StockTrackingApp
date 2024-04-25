using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StockTrackingServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductServiceController : ControllerBase
    {
        [HttpPost]
        [Route("SaveProduct")]
        public IActionResult SaveProduct(Product product)
        {
            using (var context = new Context())
            {
                var repository = new GenericRepositoryController<Product>(context);
                repository.Save(product);
            }

            return Ok("Data inserted.");
        }

        [HttpPost]
        [Route("DeleteProduct")]
        public IActionResult DeleteProduct(Product product)
        {
            using (var context = new Context())
            {
                var repository = new GenericRepositoryController<Product>(context);
                repository.Delete(product);
            }

            return Ok("Data deleted.");
        }

        [HttpPost]
        [Route("UpdateProduct")]
        public IActionResult UpdateProduct(Product product)
        {
            using (var context = new Context())
            {
                var repository = new GenericRepositoryController<Product>(context);
                repository.Update(product);
            }

            return Ok("Data updated.");
        }
    }
}
