namespace EntityFirstCode.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SM3 : DbMigration
    {
        public override void Up()
        {
            CreateStoredProcedure(
  "dbo.SinhVien_Delete",
  p => new
  {
      maSinhVien = p.String(maxLength: 20),
  },
  body:
      @"DELETE [dbo].[SinhViens]
                WHERE ([maSinhVien] = @maSinhVien)"
);

        }

        public override void Down()
        {
        }
    }
}
