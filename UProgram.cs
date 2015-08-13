using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module8Assignment
{
    class UProgram
    {
        public string programName { get; set; }
        public Degree degree { get; set; }

        public UProgram(string name)
        {
            this.programName = name;
        }
    }
}
