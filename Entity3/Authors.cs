using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity3
{
    class Authors
    {
        private string authorId;
        private String name;
       
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

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
    }
}
