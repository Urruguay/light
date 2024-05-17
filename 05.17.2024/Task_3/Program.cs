using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1;
            book1.title = "Война и мир";
            book1.author = "Лев Толстой";
            book1.year = 1869;
            book1.pageCount = 1225;

            Book book2;
            book2.title = "Преступление и наказание";
            book2.author = "Фёдор Достоевский";
            book2.year = 1866;
            book2.pageCount = 671;

            Book book3;
            book3.title = "1984";
            book3.author = "Джордж Оруэлл";
            book3.year = 1949;
            book3.pageCount = 328;

            // Задаем количество книг в массиве
            int n = 3;

            // Создаем массив книг
            Book[] books = new Book[n];



            // Инициализируем каждую книгу
            books[0] = book1;
            books[1] = book2;
            books[2] = book3;

            // Выводим информацию о каждой книге
            foreach (Book book in books)
            {
                book.Info();
            }

            Console.Read();
        }
    }
    public struct Book
    {
        public string title;
        public string author;
        public int year;
        public int pageCount;

        // Конструктор для инициализации полей
        public Book(string title, string author, int year, int pageCount)
        {
            this.title = title;
            this.author = author;
            this.year = year;
            this.pageCount = pageCount;
        }

        // Метод для вывода информации о книге
        public void Info()
        {
            Console.WriteLine($"Название: {title}");
            Console.WriteLine($"Автор: {author}");
            Console.WriteLine($"Год издания: {year}");
            Console.WriteLine($"Количество страниц: {pageCount}\n");
        }
    }
}