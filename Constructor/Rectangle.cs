using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor         
                //Create a class Rectangle & accept the value of L & B from constructor & calculate perimeter of rectangle
{
    internal class Rectangle
    {
        double l, b, perimeter;
        public Rectangle()
        {
            l=4;
            b=3;
        }
        public Rectangle(double l,double b)
        {
            this.l=l;
            this.b=b;
        }
        public void CalculatePerimeter()
        {
            perimeter= 2 * (l + b);
        }
        public string DisplayDetails()
        {
            return $" Rectangle:\n perimeter is {perimeter}";
        }
    }
}
