using System;
using System.Collections.Generic;

namespace IndexersInCSharp
{
    public class HttpCookie
    {
        public readonly Dictionary<string, string> _dictionary;
        public readonly List<string> aList;
        public DateTime Expiry { get; set; }
        


        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
            aList=new List<string>();
        }

       public string this[string key]
        {
            get => _dictionary[key];
            set
            {
                _dictionary[key] = value;
            }
        }

        public string this[int number]
        {
            get
            {
                return aList[number];
            }
            set { aList[number] = value; }
        }
    }
}
