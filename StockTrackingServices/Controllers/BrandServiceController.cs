using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StockTrackingServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandServiceController : ControllerBase
    {       
        [HttpPost]
        [Route("SaveBrand")]
        public IActionResult SaveBrand(Brand brand)
        {
            using (var context = new Context())
            {
                var repository = new GenericRepositoryController<Brand>(context);
                repository.Save(brand);
            }

            return Ok("Data inserted.");
        }

        [HttpPost]
        [Route("DeleteBrand")]
        public IActionResult DeleteBrand(Brand brand)
        {
            using (var context = new Context())
            {
                var repository = new GenericRepositoryController<Brand>(context);
                repository.Delete(brand);
            }

            return Ok("Data deleted.");
        }

        [HttpPost]
        [Route("UpdateBrand")]
        public IActionResult UpdateBrand(Brand brand)
        {
            using (var context = new Context())
            {
                var repository = new GenericRepositoryController<Brand>(context);
                repository.Update(brand);
            }
            return Ok("Data updated.");
        }
    }
}
