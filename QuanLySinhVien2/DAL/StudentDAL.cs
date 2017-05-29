using QuanLySinhVien2.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien2.DAL
{
    class StudentDAL
    {
        DataHelper dh;
        
        public StudentDAL()
        {
            dh = new DataHelper();

        }

        public Student[] getList()
        {
            Student[] students= new Student[100];
            DataTable table = dh.ExecuteQuery("select * from Student");
            int n = table.Rows.Count;
            if (table.Rows.Count == 0)
            {                
                return null;
            }

            for(int i=0;i<table.Rows.Count;i++)
            {
                DataRow dataRow = table.Rows[i];
                students[i] = GetStudentFromDataRow(dataRow);
            }
            return students;
        }

        public Student GetStudentFromDataRow(DataRow dataRow)
        {
            return new Student(dataRow[1].ToString(), dataRow[2].ToString());
        }
        
        public bool Add(Student student)
        {
            string name = student.Name;
            string address = student.Address;
            string sql = "insert into student (name,address) values('" + name + "','" + address + "')";
            try
            {
                dh.ExecuteNonQuery(sql);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool Update(Student student)
        {
            string name = student.Name;
            string address = student.Address;
            string sql = "update student set address='" + address + "' where name='" + name + "'";
            try
            {
                dh.ExecuteNonQuery(sql);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public bool Remove(string name)
        {            
            string sql = "delete from student where name='" + name +"'";
            try
            {
                dh.ExecuteNonQuery(sql);
            }
            catch
            {
                return false;
            }
            return true;
        }
    }
}
