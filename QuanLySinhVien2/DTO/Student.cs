using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien2.DTO
{
    class Student
    {
        private string name;
        private string address;

        public Student(string name, string address)
        {
            this.name = name;
            this.address = address;
        }

        public Student()
        {
        }

        public string Name
        {
            get {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        
        public string Address
        {
            get
            {
                return this.address;
            }
            set{
                address = value;
            }
        }        
    }
}
