using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class TransportCompany<T>
    {
        public T Power { get; set; }
        public double Cost { get; set; }
        public string Brand { get; set; }

        public TransportCompany(T power, double cost, string brand)
        {
            Power = power;
            Cost = cost;
            Brand = brand;
        }

        public override string ToString()
        {
            return $"\nPower: {Power}\nCost: {Cost}\nBrand: {Brand}\n";
        }
    }
}
