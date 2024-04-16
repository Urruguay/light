using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    /// <summary>
    /// Класс прямоугольника
    /// </summary>
    public class Rectangle : Figure
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override double Area()
        {
            return width * height;
        }

        public override double Perimeter()
        {
            return 2 * (width + height);
        }

        public override string GetName()
        {
            return "Прямоугольник";
        }

        public override string GetParams()
        {
            return $"Ширина: {width}\nВысота: {height}";
        }
    }
}
