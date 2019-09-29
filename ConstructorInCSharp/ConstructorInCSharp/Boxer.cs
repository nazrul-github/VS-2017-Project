using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInCSharp
{
    class Boxer
    {
        
        public string FirstName { get; set; }

        public Boxer(string name)
        {
            FirstName = name;
        }
        public string GetFirstBoxer()
        {
            string surName = "Robin";
            return surName;
        }


    }
}
