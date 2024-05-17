using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook;
            notebook.model = "HHH";
            notebook.manufacturer = "FFF";
            notebook.price = 10000000;

            notebook.Info();

            Console.Read();
        }
    }
    public struct Notebook
    {
        public string model;
        public string manufacturer;
        public double price;

        // Конструктор для инициализации полей
        public Notebook(string model, string manufacturer, double price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
        }

        // Метод для вывода полей на экран
        public void Info()
        {
            Console.WriteLine($"Модель: {model}") ;
            Console.WriteLine($"Производитель: {manufacturer}");
            Console.WriteLine($"Цена: {price}");
        }
    }
}
