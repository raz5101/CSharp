using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module8Assignment
{
    class Degree
    {
        public string degreeName { get; set; }
        public Course course { get; set; }

        public Degree(string name)
        {
            this.degreeName = name;
        }
    }
}
