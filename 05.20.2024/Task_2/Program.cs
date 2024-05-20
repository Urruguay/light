using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle<int> triangle = new Triangle<int>(0, 0, 0);
            triangle.Info();
            Console.WriteLine($"Площадь - {triangle.Area()}\n");

            Triangle<uint> triangle1 = new Triangle<uint>(2u, 3u, 4u);
            triangle1.Info();
            Console.WriteLine($"Площадь - {triangle1.Area()}\n");

            Triangle<double> triangle2 = new Triangle<double>(4.5, 5.5, 6.5);
            triangle2.Info();
            Console.WriteLine($"Площадь - {triangle2.Area():f2}\n");

            Console.Read();
        }
    }
}
