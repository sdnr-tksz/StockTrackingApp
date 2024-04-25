using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProductEntryManager : IProductEntryService
    {
        IProductEntryDal _productEntryDal;
        public ProductEntryManager(IProductEntryDal productEntryDal)
        {
            _productEntryDal = productEntryDal;
        }

        public void TAdd(ProductEntry t)
        {
            _productEntryDal.Insert(t);
        }

        public void TDelete(ProductEntry t)
        {
            _productEntryDal.Delete(t);
        }

        public ProductEntry TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProductEntry> TGetList()
        {
            return _productEntryDal.GetList();
        }

        public void TUpdate(ProductEntry t)
        {
            _productEntryDal.Update(t);
        }
    }
}
