using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task_3
{
    class Car : IComparable<Car>
    {
        
        public int Id { get; set; } 
        public string Marka { get; set; }
        public double MaxSpeed { get; set; }
        public double Price { get; set; }
        public double Skidka { get; set; }
        public Car() { }
        public Car(int id, string marka, double maxSpeed, double price, double skidka)
        {
            this.Id = id;
            this.Marka = marka;
            this.MaxSpeed = maxSpeed;
            this.Price = price;
            this.Skidka = skidka;
        }
        /// <summary>
        /// Метод для вычисления стоимости со скидкой
        /// </summary>
        public double GetDiscountedPrice()
        {
            return Price * (1 - Skidka / 100);
        }
        /// <summary>
        /// Метод CompareTo для сортировки по стоимости со скидкой
        /// </summary>
        public int CompareTo(Car other)
        {
            double thisDiscountedPrice = GetDiscountedPrice();
            double discountedPrice = other.GetDiscountedPrice();
            return thisDiscountedPrice.CompareTo(discountedPrice);
        }
        public int CompareTo1(Car other)
        {
            return Price.CompareTo(other.Price);
        }
    }
}