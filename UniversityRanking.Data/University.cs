using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityRanking.Data
{
    public class University
    {
        public int ID{ get; set; }
        public string NameOfUniversity { get; set; }
        public string Country { get; set; }
        public List<Ranking> Rankings { get; set; }
    }
}
