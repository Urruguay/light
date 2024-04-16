using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("***Компьютерный практикум № 3 (15.04.2024 г.)***");
            WriteLine("***Task -- 1***\n");

            // Создание списка книг
            List<Book> library = new List<Book>();
            {
                library.Add(new Book("1984", 150.85));
                library.Add(new Book("Гарри Поттер и узник Азкабана", 120.40));
                library.Add(new Book("Зелёная миля", 140.90));
                library.Add(new Book("Шерлок Холмс (сборник)", 100.70));
                library.Add(new Book("Властелин Колец: Возвращение короля", 89.50));
            };

            ForegroundColor = ConsoleColor.Red;
            // Вывод неотсортированных книг на экран
            WriteLine("Неотсортированные по алфавиту книги:\n");
            ResetColor();

            foreach (var book in library)
            {
                WriteLine($"Название: {book.Title}\nЦена: {book.Price}");
            }

            // Сортировка списка по алфавиту названия книги
            library.Sort();

            ForegroundColor = ConsoleColor.Green;
            // Вывод отсортированных книг на экран
            WriteLine("Отсортированные по алфавиту названия книг:\n");
            ResetColor();
            foreach (var book in library)
            {
                WriteLine($"Название: {book.Title}\nЦена: {book.Price}");
            }
            Read();
        }
    }
}
