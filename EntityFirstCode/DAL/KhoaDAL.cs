using EntityFirstCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATN.DAL
{
    class KHoaDAL
    {
        private FirstCode db = new FirstCode();
        public List<Khoa> getListKhoa()
        {
            var khoas = db.Khoas.Select(p => p);
            return khoas.ToList();
        }
    }
}
