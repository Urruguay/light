using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    /// <summary>
    /// Класс книги, реализующий интерфейс сравнения
    /// </summary>
    class Book : IComparable<Book>
    {
        // Свойства названия и цены книги
        public string Title { get; set; }
        public double Price { get; set; }

        // Конструктор класса
        public Book(string title, double price)
        {
            Title = title;
            Price = price;
        }

        // Реализация метода CompareTo для сравнения книг по названию
        public int CompareTo(Book other)
        {
            if (other == null)
                return 1;

            return this.Title.CompareTo(other.Title);
        }
    }

}
