using QuanLySinhVien2.DAL;
using QuanLySinhVien2.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien2.BLL
{
    
    class StudentBLL
    {
        private StudentDAL studentDAL = new StudentDAL();
        public Student[] getList()
        {
            return studentDAL.getList();
        }

        public bool Add(Student s)
        {
            if (studentDAL.Add(s)) return true;
            else return false;
        }

        public bool Update(Student s)
        {
            if (studentDAL.Update(s)) return true;
            else return false;
        }

        public bool Remove(string s)
        {
            if (studentDAL.Remove(s)) return true;
            else return false;
        }
    }
}
