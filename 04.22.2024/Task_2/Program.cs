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
            // Создание объекта класса DoubleTypes с разными типами параметров
            var doubleTypes = new DoubleTypes<int, string>(10, "Hello");
            doubleTypes.Print();
            var d = new DoubleTypes<double, uint>(10.1, 100);
            d.Print();
            Console.Read();
        }
    }
}
