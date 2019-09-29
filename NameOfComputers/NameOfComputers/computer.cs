using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameOfComputers
{
    class Computer
    {
        public string NameOfFirstComputer { get; set; }
        public string NameofSecondComputer { get; set; }
        public string NameofThirdComputer { get; set; }
        public Computer(string name)
        {
            NameOfFirstComputer = name;
            NameofSecondComputer = name;
            NameofThirdComputer = name;
        }
    }
}
