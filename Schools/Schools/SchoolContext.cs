using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schools
{
  public   class SchoolContext:DbContext
    {
        public SchoolContext() : base("conn") { }
        public DbSet<Subject> Subjects { get; set; }
    }

    
}
