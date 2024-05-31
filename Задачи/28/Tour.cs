using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28
{
    /// <summary>
    /// Класс Tour
    /// </summary>
    class Tour
    {
        /// <summary>
        /// Метод TourCalc без параметров
        /// </summary>
        public void TourCalc()
        {
            Console.WriteLine($"Тур: Минское море\nСтоимость: Бесплатно");
        }

        /// <summary>
        /// Метод TourCalc с одним параметром
        /// </summary>
        /// <param name="country"></param>
        public void TourCalc(string country)
        {
            Console.WriteLine($"\nТур: {country}\nСтоимость: 1 день - 50 рублей");
        }

        /// <summary>
        /// Метод TourCalc с двумя параметрами
        /// </summary>
        /// <param name="country"></param>
        /// <param name="days"></param>
        public void TourCalc(string country, int days)
        {
            int n = 50 * days;
            Console.WriteLine($"\nТур: {country}\nСтоимость: {days} день(дня, дней) - {n} рублей");
        }
    }
}
