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
    public class WarehouseManager : IWarehouseService
    {
        IWarehouseDal _warehouseDal;
        public WarehouseManager(IWarehouseDal warehouseDal)
        {
            _warehouseDal = warehouseDal;
        }

        public void TAdd(Warehouse t)
        {
            _warehouseDal.Insert(t);
        }

        public void TDelete(Warehouse t)
        {
            _warehouseDal.Delete(t);
        }

        public Warehouse TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Warehouse> TGetList()
        {
            return _warehouseDal.GetList();
        }

        public void TUpdate(Warehouse t)
        {
            _warehouseDal.Update(t);
        }
    }
}
