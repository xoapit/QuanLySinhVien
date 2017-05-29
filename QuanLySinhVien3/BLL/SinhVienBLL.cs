using QuanLySinhVien3.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien3.BLL
{
    class SinhVienBLL
    {
        private StudentDAL studentDAL = new StudentDAL();
        public SINHVIEN[] getListSV()
        {
            return studentDAL.getListSV();
        }

        public bool AddSV(SINHVIEN sv)
        {
           return studentDAL.AddSV(sv);
        }

        public bool insertSV(SINHVIEN sv)
        {
            return studentDAL.insertSV(sv);
        }

        public bool updateSV(SINHVIEN sv)
        {
            return studentDAL.updateSV(sv);
        }

        public bool UpdateSV(SINHVIEN sv)
        {
            return studentDAL.UpdateSV(sv);
        }

        public bool DeleteSV(SINHVIEN sv)
        {
           return studentDAL.DeleteSV(sv);
        }
    }
}
