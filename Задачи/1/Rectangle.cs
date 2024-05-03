using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    public class Rectangle
    {
        public double side1;
        public double side2;

        Rectangle() { }
        Rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        double Area { get { return AreaCalculator(); } }
        double Perimeter { get { return PerimeterCalculator(); } }

        public double AreaCalculator()
        {
            return side1 * side2;
        }
        public double PerimeterCalculator()
        {
            return 2 * (side1 + side2);
        }
    }
}
