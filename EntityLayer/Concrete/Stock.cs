using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Stock
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("Products")] public int ProductID { get; set; }
        [ForeignKey("ProductEntries")] public int ProductEntryID { get; set; }
        [ForeignKey("ProductOutputs")] public int ProductOutputID { get; set; }
        [ForeignKey("Warehouses")] public int WarehouseID { get; set; }
        public int EnteredQuantity { get; set; }
        public int ExtractedQuantity { get; set; }
        public int RemainingQuantity { get; set; }

    }
}
