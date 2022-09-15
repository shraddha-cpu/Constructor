using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
//Create a class Circle & accept the value of radius from constructor & calculate area of circle & display it

{
    internal class Circle
    {
        double r, area;
        public Circle()
        {
            r=2;
        }
        public Circle(double r)
        {
            this.r=r;
            
        }

        public void CalculateArea()
        {
            area= 3.14 * r * r;
        }
        public string DisplayDetails()
        {
            return $" circle:\n radius is{r} \n is area {area}";
        }
    }
}
