using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQL_1721050507.Models
{
    public class NhaCungCap507
    {
        [Key]
        public int MaNhaCungCap { get; set; }
        [StringLength(50)]
        public int TenNhaCungCap { get; set; }
    }
}