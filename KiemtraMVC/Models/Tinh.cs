using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KiemtraMVC.Models
{
    public class Tinh
    {
        [Key]
        public int Id { get; set; }
        [Required, DisplayName("Tên Tỉnh")]
        public string TenTinh { get; set; }
    }
}
