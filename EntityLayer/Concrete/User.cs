using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        [StringLength(30)]
        public string UserName { get; set; }
        [StringLength(16)]
        public string Password { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int RegistryNo { get; set; }
        public bool Role { get; set; }
    }
}
