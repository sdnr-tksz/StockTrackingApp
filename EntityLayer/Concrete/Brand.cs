using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Brand
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("User")] public int UserID { get; set; }
        [ForeignKey("Category")] public int CategoryID { get; set; }

        [StringLength(30)]
        public string BrandName { get; set; }
        [StringLength(100)]
        public string? Description { get; set; }
    }
}
