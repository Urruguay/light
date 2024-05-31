using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29
{
    class Tovar
    {
        private string name;
        private double price;
        private int kvo;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Price
        {
            get { return price; }
            set 
            {
                if (value < 1 || value > 20)
                    Console.WriteLine("Цена должна быть в диапазоне от 1 до 20");
                else
                    price = value;
            }
        }
        public int Kvo
        {
            get { return kvo; }
            set 
            {
                if (value < 0 || value > 10)
                    Console.WriteLine("Кол-во должно быть в диапазоне от 0 до 10");
                else
                    kvo = value;
            }
        }

        public Tovar() { }
        public Tovar(string name, double price, int kvo)
        {
            this.Name = name;
            this.Price = price;
            this.Kvo = kvo;
        }

        public double Calc()
        {
            return Price * Kvo;
        }
    }
}
