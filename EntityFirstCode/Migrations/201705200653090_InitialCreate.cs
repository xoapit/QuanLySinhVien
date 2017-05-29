namespace EntityFirstCode.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Khoas",
                c => new
                    {
                        maKhoa = c.String(nullable: false, maxLength: 10),
                        tenKhoa = c.String(),
                    })
                .PrimaryKey(t => t.maKhoa);
            
            CreateTable(
                "dbo.SinhViens",
                c => new
                    {
                        maSinhVien = c.String(nullable: false, maxLength: 10),
                        tenSinhVien = c.String(),
                        ngaySinh = c.DateTime(nullable: false),
                        queQuan = c.String(),
                        hoKhau = c.String(),
                        gioiTinh = c.Boolean(nullable: false),
                        diemTrungBinhTL = c.Single(nullable: false),
                        maKhoa = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.maSinhVien)
                .ForeignKey("dbo.Khoas", t => t.maKhoa)
                .Index(t => t.maKhoa);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SinhViens", "maKhoa", "dbo.Khoas");
            DropIndex("dbo.SinhViens", new[] { "maKhoa" });
            DropTable("dbo.SinhViens");
            DropTable("dbo.Khoas");
        }
    }
}
