using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StockTrackingServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductOutputServiceController : ControllerBase
    {
        [HttpPost]
        [Route("SaveProductOutput")]
        public IActionResult SaveProductOutput(ProductOutput productOutput)
        {
            using (var context = new Context())
            {
                var repository = new GenericRepositoryController<ProductOutput>(context);
                repository.Save(productOutput);
            }

            return Ok("Data inserted.");
        }

        [HttpPost]
        [Route("DeleteProductOutput")]
        public IActionResult DeleteProductOutput(ProductOutput productOutput)
        {
            using (var context = new Context())
            {
                var repository = new GenericRepositoryController<ProductOutput>(context);
                repository.Delete(productOutput);
            }

            return Ok("Data deleted.");
        }

        [HttpPost]
        [Route("UpdateProductOutput")]
        public IActionResult UpdateProductOutput(ProductOutput productOutput)
        {
            using (var context = new Context())
            {
                var repository = new GenericRepositoryController<ProductOutput>(context);
                repository.Update(productOutput);
            }

            return Ok("Data updated.");
        }
    }
}
