using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity3
{
    class Payrolls
    {
        private string payrollId;
        private string authorId;
        private float salary;
        public Authors Authors
        {
            get; set;
        }


        public string PayrollId
        {
            get
            {
                return payrollId;
            }

            set
            {
                payrollId = value;
            }
        }

        public string AuthorId
        {
            get
            {
                return authorId;
            }

            set
            {
                authorId = value;
            }
        }

        public float Salary
        {
            get
            {
                return salary;
            }

            set
            {
                salary = value;
            }
        }
    }


}
