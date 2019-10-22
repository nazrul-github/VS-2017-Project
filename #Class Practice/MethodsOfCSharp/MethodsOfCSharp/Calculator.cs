using System;

namespace MethodsOfCSharp
{
    public class Calculator
    {
       public Point Add(params Point [] newPoint)
        {
                int one =0;
            int two = 0;
            Point aPoint;
           
            foreach (var number in newPoint)
            {
                one += number.x;
                two += number.y;
            }
                aPoint = new Point(one,two);

            return aPoint;

        }
    }
}
