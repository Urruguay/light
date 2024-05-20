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
            Point<int> num = new Point<int>(2, 3);
            num.Info();

            Point<uint> num2 = new Point<uint>(3u, 4u);
            num2.Info();

            Point<double> num3 = new Point<double>(4.2, 5.1);
            num3.Info();

            Console.Read();
        }
    }
}
