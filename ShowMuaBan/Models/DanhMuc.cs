using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ShowMuaBan.Models
{
    public class DanhMuc
    {
        [Key]
        public int NguoiDangId { get; set; }

        [Required]
        [StringLength(10)]
        public string NhanHieu { get; set; }

        [Required]
        [StringLength(50)]
        public string TenSanPham { get; set; }


        public DateTime NgayDangSP { get; set; }

        //
        public virtual TaiKhoan Account { get; set; }

    }
}