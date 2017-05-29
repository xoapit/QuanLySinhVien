using QuanLySinhVien3.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien3.BLL
{
    class LopBLL
    {
        LopDAL lopDAL = new LopDAL();
        public LOP[] getListLop()
        {
            return lopDAL.getListLop();
        }
    }
}
