using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQL_1721050507.Models
{
    [Table("NhaCungCap507")]
    public class NhaCungCap507
    {
        [Key]
        [Display(Name = "ID Nhà Cung Cấp")]
        public int Manhacungcap { get; set; }
        [Display(Name = "Tên Nhà Cung Cấp")]

        [StringLength(50)]

        public string Tennhacungcap { get; set; }
        public ICollection<PDTSanPham507> sanPhams { get; set; }

    }
}