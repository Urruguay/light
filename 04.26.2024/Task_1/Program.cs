using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle<int> intTr = new Triangle<int>(3, 4, 5);
            intTr.PrintInfo();
            Console.WriteLine($"Площадь - {intTr.Area()}");

            Triangle<double> dTr = new Triangle<double>(3.5, 3.3, 3.4);
            dTr.PrintInfo();
            Console.WriteLine($"Площадь - {dTr.Area():f2}");

            Console.Read();
        }
    }
}
