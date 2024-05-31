using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tovar> tovars = new List<Tovar>
            {
                new Tovar("Молоко", 7, 2),
                new Tovar("Хлеб", 5, 5),
                new Tovar("Яйца", 1.9, 10)
            };
            double totcost = 0;
            foreach(Tovar tovar in tovars)
            {
                double cost = tovar.Calc();
                Console.WriteLine($"{tovar.Name}: {tovar.Kvo}шт. по стоимости - {tovar.Price}руб.");
                totcost += cost;
            }

            Console.WriteLine($"\nОбщая стоимость - {totcost}");

            Console.Read();
        }
    }
}
