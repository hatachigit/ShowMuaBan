namespace ShowMuaBan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifyDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TaiKhoans",
                c => new
                    {
                        NguoiDangId = c.Int(nullable: false),
                        HoTen = c.String(nullable: false, maxLength: 50),
                        TenDangNhap = c.String(nullable: false),
                        MatKhau = c.String(nullable: false),
                        RememberMe = c.Boolean(nullable: false),
                        NgaySinh = c.DateTime(nullable: false),
                        GioiTinh = c.Boolean(nullable: false),
                        SoDienThoai = c.String(nullable: false, maxLength: 12),
                    })
                .PrimaryKey(t => new { t.NguoiDangId, t.HoTen });
            
            CreateTable(
                "dbo.DanhMucs",
                c => new
                    {
                        TenSanPham = c.String(nullable: false, maxLength: 50),
                        NguoiDangId = c.Int(nullable: false),
                        HoTen = c.String(maxLength: 50),
                        NhanHieu = c.String(nullable: false, maxLength: 10),
                        NgayDangSP = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.TenSanPham)
                .ForeignKey("dbo.TaiKhoans", t => new { t.NguoiDangId, t.HoTen })
                .Index(t => new { t.NguoiDangId, t.HoTen });
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DanhMucs", new[] { "NguoiDangId", "HoTen" }, "dbo.TaiKhoans");
            DropIndex("dbo.DanhMucs", new[] { "NguoiDangId", "HoTen" });
            DropTable("dbo.DanhMucs");
            DropTable("dbo.TaiKhoans");
        }
    }
}
