using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATN.DAL
{
    class DoAnTotNghiepDAL
    {
        private LINQdbDataContext db = new LINQdbDataContext();
        public List<DoAnTotNghiep> getListDATN()
        {
            var datn = db.DoAnTotNghieps.Select(p => p);
           
            return datn.ToList();
        }
        public void addDATN(DoAnTotNghiep datn)
        {
            db.addDATN(datn.MaDoAn,datn.TenDoAn,datn.TenSinhVienTH,datn.TinhTrang,datn.NamThucHien,datn.MaHuongNC);
        }

        public void deleteDATN(DoAnTotNghiep datn)
        {
            db.deleteDATN(datn.MaDoAn);
        }
    }
}
