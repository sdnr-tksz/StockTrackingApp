using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StockTrackingServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenericRepositoryController<T> : ControllerBase where T : class
    {
        private readonly Context _context;

        public GenericRepositoryController(Context context)
        {
            _context = context;
        }

        public void Save(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            _context.SaveChanges();
        }

        public void Update(T entity)
        {

            _context.Set<T>().Update(entity);
            _context.SaveChanges();
        }
    }
}
