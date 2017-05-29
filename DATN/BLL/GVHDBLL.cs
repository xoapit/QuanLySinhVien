using DATN.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATN.BLL
{
    class GVHDBLL
    {
        private GVHDDAL gvhdDAL = new GVHDDAL();
        public List<GVHD> getListGVHD()
        {
            return gvhdDAL.getListGVHD();
        }
    }
}
