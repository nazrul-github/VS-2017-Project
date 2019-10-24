using System;

namespace Inheritance_Practice
{
    public class PresentationObject
    {
        public int width { get; set; }
        public int height { get; set; }

        public void Copy()
        {
            Console.WriteLine("Object copied to clipboard");
            
        }

        public void Duplicate()
        {
            Console.WriteLine("Object was duplicated");
        }
    }
}
