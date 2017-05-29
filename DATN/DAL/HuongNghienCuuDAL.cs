using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATN.DAL
{
    class HuongNghienCuuDAL
    {
        private LINQdbDataContext db = new LINQdbDataContext();
        public List<HuongNghienCuu> getListHuongNC()
        {
            var huongncs = db.HuongNghienCuus.Select(p => p);
            return huongncs.ToList();
        }
    }
}
