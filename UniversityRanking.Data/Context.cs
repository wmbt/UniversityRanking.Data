using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityRanking.Data
{
    public class Context:DbContext

    {
        public DbSet<University> Universities { get; set; }
        public DbSet<Ranking> Ranking { get; set; }

        public Context() : base("localsql")
        { }
    }
}
