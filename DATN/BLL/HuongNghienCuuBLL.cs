using DATN.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATN.BLL
{
    class HuongNghienCuuBLL
    {
        HuongNghienCuuDAL huongNCDAL = new HuongNghienCuuDAL();
        public List<HuongNghienCuu> getListHuongNC()
        {
            return huongNCDAL.getListHuongNC();
        }
    }
}
