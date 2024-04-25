﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        [ForeignKey("User")] public int UserID { get; set; }
        [StringLength(50)]
        public string CategoryName { get; set; }
        [StringLength(100)]
        public string? Description { get; set; }
    }
}
