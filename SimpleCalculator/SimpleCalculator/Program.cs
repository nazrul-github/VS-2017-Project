using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    partial class Program
    {
        static void Main(string[] args)
        {
            string someText = "Here is some text";
            string someOtherText = "Here is some Text";

           bool isEqual = someText.Equals(someOtherText,StringComparison.OrdinalIgnoreCase);

            string addedText = $"{someText} {someOtherText} here is some more text.";

        }
    }
}
