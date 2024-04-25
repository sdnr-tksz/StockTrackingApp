using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("User")] public int UserID { get; set; }
        [ForeignKey("Category")] public int CategoryID { get; set; }
        [ForeignKey("Brand")] public int BrandID { get; set; }
        public string ProductName { get; set; }
        public string Unit { get; set; }
        public string? Description { get; set; }
    }
}
