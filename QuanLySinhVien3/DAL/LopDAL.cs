using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien3.DAL
{
    class LopDAL
    {

        LINQdbDataContext db = new LINQdbDataContext();
        public LOP[] getListLop()
        {
            var lop = db.LOPs.Select(p => p);
            LOP[] lops = new LOP[lop.Count()];
            int i = 0;
            foreach (var l in lop)
            {
                LOP temp = new LOP
                {
                    ID_Class = l.ID_Class,
                    Ten_Class = l.Ten_Class
                };
                lops[i++] = temp;
            }
            return lops;
        }
    }
}