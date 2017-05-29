namespace EntityFirstCode
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    public class FirstCode : DbContext
    {
        public FirstCode()
            : base("FirstCode")
        {
            Database.SetInitializer<FirstCode>(new TaoDataBase());
        }

        public DbSet<SinhVien> SinhViens { get; set; }
        public DbSet<Khoa> Khoas { get; set; }
        public class TaoDataBase : CreateDatabaseIfNotExists<FirstCode>
        {
            protected override void Seed(FirstCode context)
            {
                context.Khoas.Add(new Khoa { maKhoa = "KH01", tenKhoa = "Cong Nghe Thong Tin" });
                context.Khoas.Add(new Khoa { maKhoa = "KH02", tenKhoa = "Dien Tu Vien Thong" });
                context.Khoas.Add(new Khoa { maKhoa = "KH03", tenKhoa = "Xay Dung Dan Dung" });
                context.SaveChanges();
                base.Seed(context);
            }
        }
    }

    public class SinhVien
    {
        public SinhVien() { }
        [Key]
        [MaxLength(10)]
        public string maSinhVien { get; set; }
        public string tenSinhVien { get; set; }
        public DateTime ngaySinh { get; set; }

        public string queQuan { get; set; }
        public string hoKhau { get; set; }

        public bool gioiTinh { get; set; }

        public float diemTrungBinhTL { get; set; }

        public string maKhoa { get; set; }
        public virtual Khoa khoa { get; set; }

        public delegate bool CompareObj(object o1, object o2);
        public static CompareObj cmpMaSinhVien = new CompareObj(SinhVien.CompareMaSinhVien);
        public static CompareObj cmpTenSinhVien = new CompareObj(SinhVien.CompareTenSinhVien);
        public static CompareObj cmpTenKhoa = new CompareObj(SinhVien.CompareTenKhoa);
        public static CompareObj cmpDiemTrungBinh = new CompareObj(SinhVien.CompareDiemTrungBinh);
        public static bool CompareMaSinhVien(object p1, object p2){
            if (string.Compare(((SinhVien)p1).maSinhVien, ((SinhVien)p2).maSinhVien) > 0)
            {
                return true;
            }else
            {
                return false;
            }
       }
        public static bool CompareTenSinhVien(object p1, object p2)
        {
            if (string.Compare(((SinhVien)p1).tenSinhVien, ((SinhVien)p2).tenSinhVien) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CompareTenKhoa(object p1, object p2)
        {
            if (string.Compare(((SinhVien)p1).khoa.tenKhoa, ((SinhVien)p2).khoa.tenKhoa) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CompareDiemTrungBinh(object p1, object p2)
        {
            if (((SinhVien)p1).diemTrungBinhTL >((SinhVien)p2).diemTrungBinhTL)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class Khoa
    {

        public Khoa() { }
        [Key]
        [MaxLength(10)]
        public string maKhoa { get; set; }
        public string tenKhoa { get; set; }
        
        public virtual ICollection<SinhVien> sinhVien { get; set; }
      
    }
}