using Microsoft.AspNet.Identity;
using ShowMuaBan.Models;
using ShowMuaBan.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShowMuaBan.Controllers
{
    public class DangSanPhamController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        // GET: DangSanPham
        public DangSanPhamController()
        {
            _dbContext = new ApplicationDbContext();
        }

        
        
        public ActionResult ThemSanPham (DanhMucViewModel viewModel)
        {

            var danhmuc = new DanhMuc
            {
                //NguoiDangId = User.Identity.GetUserId(),
                NhanHieu = viewModel.NhanHieu,
                TenSanPham = viewModel.TenSanPham,
                NgayDangSP = viewModel.GetDateTime(),
                
            };
            _dbContext.DanhMucs.Add(danhmuc);
            _dbContext.SaveChanges();
            return RedirectToAction("IndexTrangChu","TrangChu");
        }
    }
}