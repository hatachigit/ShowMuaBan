using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ShowMuaBan.Models
{
    public class Account
    {
        [Key]
        [Column(Order =1)]
        public int UserId { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        [Required]
        public string HoTen { get; set; }

        public DateTime NgaySinh { get; set; }

        public bool GioiTinh { get; set; }

        [Required]
        [StringLength(12)]
        public string SoDienThoai { get; set; }

        public virtual ICollection<DanhMuc> DanhMucs { get; set; }

    }
}