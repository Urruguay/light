using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание объектов универсального класса с разными типами параметра мощности
            var plane1 = new TransportCompany<int>(500, 1000000, "Boeing");
            var plane2 = new TransportCompany<double>(550.5, 1200000, "Airbus");
            var plane3 = new TransportCompany<string>("620", 1500000, "Embraer");

            // Вывод информации о самолетах
            WriteLine($"Plane 1: {plane1} ");
            WriteLine($"Plane 2: {plane2} ");
            WriteLine($"Plane 3: {plane3} ");

            Read();
        }
    }
}
