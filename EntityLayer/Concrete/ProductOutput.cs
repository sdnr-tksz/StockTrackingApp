using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ProductOutput
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("User")] public int UserID { get; set; }
        [ForeignKey("Product")] public int ProductID { get; set; }
        [ForeignKey("Category")] public int CategoryID { get; set; }
        [ForeignKey("Warehouse")] public int WarehouseID { get; set; }
        public string? province { get; set; }
        public string? district { get; set; }
        public string? neighborhood { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
    }
}
