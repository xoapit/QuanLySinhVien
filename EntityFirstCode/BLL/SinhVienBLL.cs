using DATN.DAL;
using EntityFirstCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EntityFirstCode.SinhVien;

namespace DATN.BLL
{
    class SinhVienBLL
    {
        
        private SinhVienDAL sinhVienDAL = new SinhVienDAL();
        public List<SinhVien> getListSinhVien()
        {
            return sinhVienDAL.getListSinhVien();
        }

        public void addSinhVien(SinhVien sinhvien)
        {
            sinhVienDAL.addSinhVien(sinhvien);
        }

        public void deleteSinhVien(SinhVien sinhvien)
        {
            sinhVienDAL.deleteSinhVien(sinhvien);
        }

        public void updateSinhVien(SinhVien sinhvien)
        {
            sinhVienDAL.updateSinhVien(sinhvien);
        }

        public List<SinhVien> sortSinhVien(string condition)
        {
            return sinhVienDAL.sortSinhVien(condition);
        }
    }
}
