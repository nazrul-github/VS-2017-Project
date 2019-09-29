using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesInCSharp
{
    class Computer
    {
        private string computerName;
        private int power;
        public int ComputerPower
        {
            get
            {
                return power;
            }
            set
            {
                power = value;
            }
        }

        public string ComputerName
        {
            get
            {
                return computerName;
            }
            set
            {
                computerName = value;
            }
        }

       /* public void SetComputerName(string name)
        {
            computerName = name;
        }
        public string GetComputerName()
        {
            return computerName;
        }*/

    }
}
