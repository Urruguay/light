using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using static System.Console;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TourOperator> tours = new List<TourOperator>();
            {
                tours.Add(new TourOperator(1, "tourist", 2000, 20000));
                tours.Add(new TourOperator(2, "InfoTour", 2010, 30000));
                tours.Add(new TourOperator(3, "basatour", 2015, 25000));
            };

            Write("Введите название фирмы: ");
            string name = ReadLine();
            bool not_found = false;
            
            for (int i = 0; i < tours.Count; i++)
            {
                if(tours[i].Name == name)
                {
                    WriteLine($"ИНН - {tours[i].Id}\nProfit - {tours[i].Profit}");
                    not_found = true;
                }
            }
            if (not_found == false)
            {
                WriteLine($"Фирмы {name} не существует");
            }

            for(int j = 0; j < tours.Count; j++)
            {

            }

            Read();
        }
    }
}
