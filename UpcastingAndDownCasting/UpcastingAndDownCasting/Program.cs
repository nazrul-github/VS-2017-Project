using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingAndDownCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            //StreamReader reader = new StreamReader(new MemoryStream());

            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(1);
            //arrayList.Add("Mosh");

            //var anotherList = new List<Shape>();

            Shape shape = new Text();
            Text text = (Text) shape;
        }
    }
}
