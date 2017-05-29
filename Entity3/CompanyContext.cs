using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Entity3
{
    class CompanyContext:Context
    {
        public DbSet<Authors> Authors { get; set; };

    }
}
