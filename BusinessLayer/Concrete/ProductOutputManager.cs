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
    public class ProductOutputManager : IProductOutputService
    {
        IProductOutputDal _productOutputDal;
        public ProductOutputManager(IProductOutputDal productOutputDal)
        {
            _productOutputDal = productOutputDal;
        }
        public void TAdd(ProductOutput t)
        {
            _productOutputDal.Insert(t);
        }

        public void TDelete(ProductOutput t)
        {
            _productOutputDal.Delete(t);
        }

        public ProductOutput TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<ProductOutput> TGetList()
        {
            return _productOutputDal.GetList();
        }

        public void TUpdate(ProductOutput t)
        {
            _productOutputDal.Update(t);
        }
    }
}
