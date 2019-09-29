using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggingInCSharp
{
    class Boxer
    {

        private int punchPower;

        public void SetPunchPower(int boxerPunchPower) {
            punchPower = boxerPunchPower;
        }
        public int GetPunchPower()
        {
            return punchPower;
        }
    }
}
