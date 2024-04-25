using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StockTrackingServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationServiceController : ControllerBase
    {
        [HttpPost]
        [Route("SaveUser")]
        public IActionResult SaveUse(User saveUser)
        {
            using (var context = new Context())
            {
                var repository = new GenericRepositoryController<User>(context);
                repository.Save(saveUser);
            }

            return Ok("User saved.");
        }

        [HttpPost]
        [Route("DeleteUser")]
        public IActionResult DeleteUser(User deleteUser)
        {
            using (var context = new Context())
            {
                var repository = new GenericRepositoryController<User>(context);
                repository.Delete(deleteUser);
            }

            return Ok("User deleted.");
        }

        [HttpPost]
        [Route("UpdateUser")]
        public IActionResult UpdateUser(User updatedUser)
        {
            using (var context = new Context())
            {
                var repository = new GenericRepositoryController<User>(context);
                repository.Update(updatedUser);
            }

            return Ok("User updated.");
        }
    }
}
