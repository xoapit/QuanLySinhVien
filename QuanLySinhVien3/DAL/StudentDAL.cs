using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien3.DAL
{
    class StudentDAL
    {
        private LINQdbDataContext db = new LINQdbDataContext();
        public SINHVIEN[] getListSV()
        {
            var sv = db.SINHVIENs.Select(p => p);
            SINHVIEN[] arr = new SINHVIEN[sv.Count()];
            int i = 0;
            foreach (var sinhvien in sv)
            {
                SINHVIEN s = new SINHVIEN()
                {
                    MSSV = sinhvien.MSSV,
                    Name = sinhvien.Name,
                    Birthday = sinhvien.Birthday,
                    Gender = sinhvien.Gender,
                    Address = sinhvien.Address,
                    Mobile = sinhvien.Mobile,
                    ID_Class = sinhvien.ID_Class
                };
                arr[i++] = s;
            }
            return arr;
        }

        public bool AddSV(SINHVIEN sv)
        {
            try
            {
                //db.SINHVIENs.InsertOnSubmit(sv);
                insertSV(sv);
                return true;
            }
            finally
            {
                db.SubmitChanges();
            }
            return false;
        }

        public bool insertSV(SINHVIEN sv)
        {
            try
            {
                db.insertSV(sv.MSSV, sv.Name, sv.Birthday, sv.Gender, sv.Address, sv.Mobile, sv.ID_Class);

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool updateSV(SINHVIEN sv)
        {
            try
            {
                db.updateSV(sv.MSSV, sv.Name, sv.Birthday, sv.Gender, sv.Address, sv.Mobile, sv.ID_Class);

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool UpdateSV(SINHVIEN sv)
        {
            try
            {
                var sinhvien = db.SINHVIENs.Where(p => p.MSSV == sv.MSSV).Select(p => p);
                foreach (SINHVIEN s in sinhvien)
                {
                    s.Name = sv.Name;
                    s.Mobile = sv.Mobile;
                    s.Address = sv.Address;
                    s.Birthday = sv.Birthday;
                    s.ID_Class = sv.ID_Class;
                    s.Gender = sv.Gender;
                }
                return true;
            }
            finally
            {
                db.SubmitChanges();
            }
            return false;
        }

        public bool DeleteSV(SINHVIEN sv)
        {
            try
            {
                var sinhvien = db.SINHVIENs.Where(p => p.MSSV == sv.MSSV).Select(p => p);
                db.SINHVIENs.DeleteAllOnSubmit(sinhvien);
                return true;
            }
            finally
            {
                db.SubmitChanges();
            }
            return false;
        }
    }
}
