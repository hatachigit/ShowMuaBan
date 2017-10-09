namespace ShowMuaBan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modify_danhmuc : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DanhMucs", new[] { "NguoiDangId", "HoTen" }, "dbo.TaiKhoans");
            DropIndex("dbo.DanhMucs", new[] { "NguoiDangId", "HoTen" });
            AlterColumn("dbo.DanhMucs", "HoTen", c => c.String(nullable: false, maxLength: 50));
            CreateIndex("dbo.DanhMucs", new[] { "NguoiDangId", "HoTen" });
            AddForeignKey("dbo.DanhMucs", new[] { "NguoiDangId", "HoTen" }, "dbo.TaiKhoans", new[] { "NguoiDangId", "HoTen" }, cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DanhMucs", new[] { "NguoiDangId", "HoTen" }, "dbo.TaiKhoans");
            DropIndex("dbo.DanhMucs", new[] { "NguoiDangId", "HoTen" });
            AlterColumn("dbo.DanhMucs", "HoTen", c => c.String(maxLength: 50));
            CreateIndex("dbo.DanhMucs", new[] { "NguoiDangId", "HoTen" });
            AddForeignKey("dbo.DanhMucs", new[] { "NguoiDangId", "HoTen" }, "dbo.TaiKhoans", new[] { "NguoiDangId", "HoTen" });
        }
    }
}
