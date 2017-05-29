using DATN.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATN.BLL
{
    class DoAnTotNghiepBLL
    {
        
        private DoAnTotNghiepDAL datnDAL = new DoAnTotNghiepDAL();
        public List<DoAnTotNghiep> getListDATN()
        {
            return datnDAL.getListDATN();
        }

        public void addDATN(DoAnTotNghiep datn)
        {
            datnDAL.addDATN(datn);
        }

        public void deleteDATN(DoAnTotNghiep datn)
        {
            datnDAL.deleteDATN(datn);
        }
    }
}
