using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Sports
    {
        private string sportName;

        public void SetSportName(string name)
        {
            sportName = name;
        }
        public string GetSportName()
        {
            return sportName;
        }
    }
}
