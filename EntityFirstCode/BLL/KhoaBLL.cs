using DATN.DAL;
using EntityFirstCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATN.BLL
{
    class KhoaBLL
    {
        private KHoaDAL khoaDAL = new KHoaDAL();
        public List<Khoa> getListKhoa()
        {
            return khoaDAL.getListKhoa();
        }
    }
}
