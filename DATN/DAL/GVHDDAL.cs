using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATN.DAL
{
    class GVHDDAL
    {
        private LINQdbDataContext db = new LINQdbDataContext();
        public List<GVHD> getListGVHD()
        {
            var gvs = db.GVHDs.Select(p => p);
            return gvs.ToList();
        }
    }
}
