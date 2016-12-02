using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityRanking.Data;

namespace UniversityRank.Data.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (var c = new Context())
            {
                c.Ranking.Count();

                Repository r = new Repository(c);
                var data1 = r.q1(2014);
                var data2 = r.q2(2014); 
                var data3 = r.q3("Dartmouth College"); 
                var data4 = r.q4();

               
            }
        }
    }
}
