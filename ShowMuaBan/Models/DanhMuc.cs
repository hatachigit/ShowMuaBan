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

        [Display(Name = "Id người đăng")]
        public int NguoiDangId { get; set; }

        [Key]
        [Required(ErrorMessage = "Phải điền tên sản phẩm")]
        [StringLength(50)]
        [Display(Name = "Tên sản phẩm")]
        public string TenSanPham { get; set; }

        [StringLength(50)]
        [Required]
        [Display(Name = "Họ tên người đăng")]
        public string HoTen { get; set; }

        [Required(ErrorMessage = "Phải điền nhãn hiệu")]
        [StringLength(10)]
        [Display(Name ="Nhãn hiệu")]
        public string NhanHieu { get; set; }

        

        [Required(ErrorMessage = "Phải điền ngày đăng vào")]
        [Display(Name = "Ngày đăng")]
        public DateTime NgayDangSP { get; set; }

        
        public virtual TaiKhoan TaiKhoan { get; set; }

       
    }
}