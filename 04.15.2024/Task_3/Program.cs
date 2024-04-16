using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("***Компьютерный практикум № 3 (15.04.2024 г.)***");
            WriteLine("***Task -- 3***\n");

            List<Car> cars = new List<Car>();
            {
                cars.Add(new Car(1, "Toyota", 180, 45000, 50.0));
                cars.Add(new Car(2, "Audi", 200, 67000, 7.3));
                cars.Add(new Car(3, "BMW", 170, 27000, 1.0));
                cars.Add(new Car(4, "Ford", 190, 30000, 4.5));
            };

            ForegroundColor = ConsoleColor.Green;
            WriteLine("Неотсортированный:");
            ResetColor();
            foreach (var mcar in cars)
            {
                WriteLine($"Id - {mcar.Id}\nМарка: {mcar.Marka}\nМакс.Скорость: {mcar.MaxSpeed}\nСтоимость: {mcar.Price}" +
                    $"\nСтоимость со скидкой: {mcar.GetDiscountedPrice()}\nСкидка: {mcar.Skidka}\n");
            }

            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("\nОтсортированный по цене со скидкой:");
            ResetColor();
            cars.Sort();
            foreach (var mcar in cars)
            {
                WriteLine($"Id - {mcar.Id}\nМарка: {mcar.Marka}\nМакс.Скорость: {mcar.MaxSpeed}\nСтоимость: {mcar.Price}" +
                    $"\nСтоимость со скидкой: {mcar.GetDiscountedPrice()}\nСкидка: {mcar.Skidka}\n");
            }
            Read();
        }
    }
}
