using System;
using static System.Console;

namespace Task_4
{
    /// <summary>
    /// Абстрактный класс для фигур
    /// </summary>
    public abstract class Figure : IComparable<Figure>
    {

        /// <summary>
        /// Метод для получения названия фигуры
        /// </summary>
        public abstract string GetName();
        /// <summary>
        /// Метод для получения параметров фигуры
        /// </summary>
        public abstract string GetParams();

        /// <summary>
        /// Абстрактный метод для вычисления площади
        /// </summary>
        public abstract double Area();
        /// <summary>
        /// Абстрактный метод для вычисления периметра
        /// </summary>
        public abstract double Perimeter();

        /// <summary>
        /// Метод для вывода информации о фигуре
        /// </summary>
        public virtual void PrintInfo()
        {
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine($"Фигура: {GetName()}\n");
            ResetColor();

            WriteLine($"Площадь: {Area():f2}\nПериметр: {Perimeter():f2}");

            ForegroundColor = ConsoleColor.DarkYellow;
            WriteLine($"\n{GetParams()}");
            ResetColor();
        }

        /// <summary>
        /// Реализация метода CompareTo для сравнения фигур по площади
        /// </summary>
        public int CompareTo(Figure other)
        {
            return Area().CompareTo(other.Area());
        }
    }
}
