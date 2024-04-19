using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task_1
{
    /// <summary>
    ///  класс «Туристическая фирма»
    /// </summary>
    class TourOperator
    {
        /// <summary>
        /// Поле названия фирмы
        /// </summary>
        private string name;
        /// <summary>
        /// Поле года создания фирмы
        /// </summary>
        private int year;
        /// <summary>
        /// Поле ИНН фирмы
        /// </summary>
        private int id;
        /// <summary>
        /// Поле прибыли за текущий год
        /// </summary>
        private double profit;

        public string Name { get; set; }
        public int Year { get; set; }
        public int Id { get; set; }
        public double Profit { get; set; }

        /// <summary>
        /// Конструктор по умолчанию(без параметров)
        /// </summary>
        public TourOperator() { }
        /// <summary>
        /// Конструктор с параметрами
        /// (инициализация полей)
        public TourOperator(int id, string name, int year, double profit)
        {
            this.Id = id;
            this.Name = name;
            this.Year = year;
            this.Profit = profit;
        }
        /// <summary>
        /// Метод получения информации о фирме
        /// </summary>
        public void Info()
        {
            WriteLine($"ИНН - {id}\nНазвание Фирмы - {name}\n" +
                $"Год создания Фирмы - {year}\nПрибыль за текущий год - {profit}");
        }
    }
}
