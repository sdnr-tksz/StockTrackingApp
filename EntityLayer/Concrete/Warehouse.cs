using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Warehouse
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("User")] public int UserID { get; set; }
        [StringLength(50)]
        public string WarehouseName { get; set; }
        [StringLength(50)]
        public string province { get; set; }
        [StringLength(50)]
        public string district { get; set; }
        [StringLength(50)]
        public string neighborhood { get; set; }
        [StringLength(50)]
        public string street { get; set; }
        [StringLength(100)]
        public string address { get; set; }
    }
}
