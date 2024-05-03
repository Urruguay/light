using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Введите длину стороны 1 - ");
            double side1 = Convert.ToDouble(ReadLine());
            Write("Введите длину стороны 2 - ");
            double side2 = Convert.ToDouble(ReadLine());

            Rectangle rectangle = new Rectangle(side1, side2);
            
            WriteLine($"Периметр прямоугольника:  {rectangle.PerimeterCalculator()}");
            WriteLine($"Площадь прямоугольника:  {rectangle.AreaCalculator()}");
        }
    }
}
