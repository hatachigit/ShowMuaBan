namespace ShowMuaBan.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class chinhsuaAccount : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        HoTen = c.String(nullable: false, maxLength: 50),
                        NgaySinh = c.DateTime(nullable: false),
                        GioiTinh = c.Boolean(nullable: false),
                        SoDienThoai = c.String(nullable: false, maxLength: 12),
                    })
                .PrimaryKey(t => new { t.UserId, t.HoTen });
            
            CreateTable(
                "dbo.DanhMucs",
                c => new
                    {
                        NguoiDangId = c.Int(nullable: false, identity: true),
                        NhanHieu = c.String(nullable: false, maxLength: 10),
                        TenSanPham = c.String(nullable: false, maxLength: 50),
                        NgayDangSP = c.DateTime(nullable: false),
                        Account_UserId = c.Int(),
                        Account_HoTen = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.NguoiDangId)
                .ForeignKey("dbo.Accounts", t => new { t.Account_UserId, t.Account_HoTen })
                .Index(t => new { t.Account_UserId, t.Account_HoTen });
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.DanhMucs", new[] { "Account_UserId", "Account_HoTen" }, "dbo.Accounts");
            DropIndex("dbo.DanhMucs", new[] { "Account_UserId", "Account_HoTen" });
            DropTable("dbo.DanhMucs");
            DropTable("dbo.Accounts");
        }
    }
}
