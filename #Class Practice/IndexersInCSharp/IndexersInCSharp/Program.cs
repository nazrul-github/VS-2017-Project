using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexersInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            HttpCookie cookie = new HttpCookie();
            cookie._dictionary["name"] = "Robin";
            cookie.aList.Add("Abdul");
        }
    }
}
