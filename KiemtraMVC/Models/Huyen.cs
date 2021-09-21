using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace KiemtraMVC.Models
{
    public class Huyen
    {
        [Key]
        public int IdHuyen { get; set; }
        [Required, DisplayName("Tên Huyện")]
        public string TenHuyen { get; set; }
        [Required, DisplayName("Id Tỉnh")]
        public int IdTinh { get; set; }
    }
}
