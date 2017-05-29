using EntityFirstCode;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EntityFirstCode.SinhVien;

namespace DATN.DAL
{
    class SinhVienDAL
    {
        private FirstCode db = new FirstCode();

        public List<SinhVien> getListSinhVien()
        {
            var sinhviens = db.SinhViens.Select(p => p);
            return sinhviens.ToList();
        }
        public void addSinhVien(SinhVien sinhvien)
        {
            db.SinhViens.Add(sinhvien);
            db.SaveChanges();
        }

        public async void deleteSinhVien(SinhVien sinhvien)
        {
            try
            {
                //SqlParameter category = new SqlParameter("@maSinhVien", sinhvien.maSinhVien);
                //await db.Database.ExecuteSqlCommandAsync("SinhVien_Delete @maSinhVien", category);
                //db.SaveChanges();
                db.SinhViens.Remove(sinhvien);
                db.SaveChanges();
            }catch(Exception e) { }
        }

        public void updateSinhVien(SinhVien sinhvien)
        {
            List<SinhVien> sinhviens = db.SinhViens.Select(p => p).Where(p => p.maSinhVien == sinhvien.maSinhVien).ToList();
            foreach (SinhVien sv in sinhviens)
            {
                sv.tenSinhVien = sinhvien.tenSinhVien;
                sv.gioiTinh = sinhvien.gioiTinh;
                sv.hoKhau = sinhvien.hoKhau;
                sv.maKhoa = sinhvien.maKhoa;
                sv.diemTrungBinhTL = sinhvien.diemTrungBinhTL;
                sv.ngaySinh = sinhvien.ngaySinh;
                sv.queQuan = sv.queQuan;            
            }

            db.SaveChanges();
        }

        public void Sort(object[] objs, CompareObj cmp)
        {
            for (int i = 0; i < objs.Length - 1; i++)
            {
                for (int j = i; j < objs.Length; j++)
                {
                    if (cmp(objs[i], objs[j]))
                    {
                        Object temp = objs[j];
                        objs[j] = objs[i];
                        objs[i] = temp;
                    }
                }
            }
        }

        public List<SinhVien> sortSinhVien(string condition)
        {
            List<SinhVien> svs = this.getListSinhVien().Select(p => p).ToList();
            List<SinhVien> sortedList;
            CompareObj cmp;
            SinhVien[] arr;
            if (condition.Equals("Mã sinh viên"))
            {
                //sortedList = svs.OrderBy(p => p.maSinhVien).ToList();
                cmp = new CompareObj(SinhVien.cmpMaSinhVien);
                arr = svs.ToArray();
                this.Sort(arr, cmp);
            }
            else if (condition.Equals("Họ và tên"))
            {
                //sortedList = svs.OrderBy(p => p.tenSinhVien).ToList();
                cmp = new CompareObj(SinhVien.cmpTenSinhVien);
                arr = svs.ToArray();
                this.Sort(arr, cmp);
            }
            else if (condition.Equals("Tên Khoa"))
            {
                //sortedList = svs.OrderBy(p => p.khoa.tenKhoa).ToList();
                cmp = new CompareObj(SinhVien.cmpTenKhoa);
                arr = svs.ToArray();
                this.Sort(arr, cmp);
            }
            else if (condition.Equals("Điểm trung bình tích lũy"))
            {
                //sortedList = svs.OrderBy(p => p.diemTrungBinhTL).ToList();
                cmp = new CompareObj(SinhVien.cmpDiemTrungBinh);
                arr = svs.ToArray();
                this.Sort(arr, cmp);
            }
            else
            {
                arr = svs.ToArray();
            }
            var dssv = arr.ToList().Select(p => new { p.maSinhVien, p.tenSinhVien, p.ngaySinh, p.gioiTinh, p.diemTrungBinhTL, p.khoa.tenKhoa });
            return (List<SinhVien>)arr.ToList();
        }
    }
}
