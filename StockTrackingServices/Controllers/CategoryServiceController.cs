using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StockTrackingServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryServiceController : ControllerBase
    {

        [HttpPost]
        [Route("SaveCategory")]
        public IActionResult SaveCategory(Category category)
        {
            using (var context = new Context())
            {
                var repository = new GenericRepositoryController<Category>(context);
                repository.Save(category);
            }

            return Ok("Data inserted.");
        }

        [HttpPost]
        [Route("DeleteCategory")]
        public IActionResult DeleteCategory(Category category)
        {
            using (var context = new Context())
            {
                var repository = new GenericRepositoryController<Category>(context);
                repository.Delete(category);
            }

            return Ok("Data deleted.");
        }

        [HttpPost]
        [Route("UpdateCategory")]
        public IActionResult UpdateCategory(Category category)
        {
            using (var context = new Context())
            {
                var repository = new GenericRepositoryController<Category>(context);
                repository.Update(category);
            }

            return Ok("Data updated.");
        }
    }
}
