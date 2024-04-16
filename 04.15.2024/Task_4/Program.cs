using System;
using static System.Console;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("***Компьютерный практикум № 3 (15.04.2024 г.)***");
            WriteLine("***Task -- 4***\n");

            Figure[] figures = new Figure[]
            {
                new Rectangle(5, 4),
                new Triangle(3, 4, 5),
                new Circle(2.5)
            };
            // Вывод информации о фигурах
            foreach (var figure in figures)
            {
                figure.PrintInfo();
                WriteLine();
            }

            // Сортировка фигур по площади
            Array.Sort(figures);

            // Вывод отсортированных фигур
            ForegroundColor = ConsoleColor.Green;
            WriteLine("Фигуры, отсортированные по площади:\n");
            ResetColor();
            foreach (var figure in figures)
            {
                figure.PrintInfo();
                WriteLine();
            }
            Read();
        }
    }
}
