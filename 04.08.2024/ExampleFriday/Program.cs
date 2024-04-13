using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ExampleFriday
{
    class Program
    {
        //                Задание на пятницу
        // Описать интерфейс для геометрических фигур, описать методы
        // 1метод - метод возвращающий площадь
        // 2метод - метод возвращающий периметр
        // Описать классы прямоугольника, треугольника и окружности реализующие этот интерфейс,
        // у всех прооизводных классов должны быть методы вычисления периметра и площади.
        // Кроме этого в производных классах необходимо переопределить метод
        // возвращающий строковое название фигуры и ее парметры.
        // Параметры фигур должны создаваться при создании экземпляра класса.
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(5, 4);
            Triangle triangle = new Triangle(3, 4, 5);
            Circle circle = new Circle(2.5);

            //Прямоугольник
            ForegroundColor = ConsoleColor.Magenta;
            WriteLine(rectangle.GetName());
            ResetColor();

            ForegroundColor = ConsoleColor.DarkYellow;
            WriteLine($"Парметры: \n{rectangle.GetParams()}");
            ResetColor();

            WriteLine($"Площадь: {rectangle.Area()}\tПериметр: {rectangle.Perimeter()}\n");

            //Треугольник
            ForegroundColor = ConsoleColor.Green;
            WriteLine(triangle.GetName());
            ResetColor();
            ForegroundColor = ConsoleColor.DarkYellow;
            WriteLine($"Парметры: \n{triangle.GetParams()}");
            ResetColor();
            WriteLine($"Площадь: {triangle.Area()}\tПериметр: {triangle.Perimeter()}\n");

            //Окружность
            ForegroundColor = ConsoleColor.DarkCyan;
            WriteLine(circle.GetName());
            ResetColor();
            ForegroundColor = ConsoleColor.DarkYellow;
            WriteLine($"Парметры: \n{circle.GetParams()}");
            ResetColor();
            WriteLine($"Площадь: {circle.Area():f2}\tПериметр: {circle.Perimeter():f2}\n");
            Read();
        }
        /// <summary>
        /// Интерфейс для геометрических фигур
        /// </summary>
        public interface IFigures
        {
            /// <summary>
            /// Метод для вычисления площади фигуры
            /// </summary>
            double Area();
            /// <summary>
            /// Метод для вычисления периметра фигуры
            /// </summary>
            double Perimeter();
            /// <summary>
            /// Метод для получения названия фигуры
            /// </summary>
            string GetName();
            /// <summary>
            /// Метод для получения параметров фигуры
            /// </summary>
            string GetParams();
        }

        /// <summary>
        /// Класс прямоугольника
        /// </summary>
        public class Rectangle : IFigures
        {
            private double width;
            private double height;

            public Rectangle(double width, double height)
            {
                this.width = width;
                this.height = height;
            }

            public double Area()
            {
                return width * height;
            }

            public double Perimeter()
            {
                return 2 * (width + height);
            }

            public string GetName()
            {
                return "Прямоугольник";
            }

            public string GetParams()
            {
                return $"Ширина: {width}\nВысота: {height}";
            }
        }

        /// <summary>
        /// Класс треугольника
        /// </summary>
        public class Triangle : IFigures
        {
            private double side1;
            private double side2;
            private double side3;

            public Triangle(double side1, double side2, double side3)
            {
                this.side1 = side1;
                this.side2 = side2;
                this.side3 = side3;
            }

            public double Area()
            {
                // Формула Герона для вычисления площади треугольника
                double s = (side1 + side2 + side3) / 2;
                return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
            }

            public double Perimeter()
            {
                return side1 + side2 + side3;
            }

            public string GetName()
            {
                return "Треугольник";
            }

            public string GetParams()
            {
                return $"Сторона_1: {side1}\nСторона_2: {side2}\nСторона_3: {side3}";
            }
        }

        /// <summary>
        /// Класс окружности
        /// </summary>
        public class Circle : IFigures
        {
            private double radius;

            public Circle(double radius)
            {
                this.radius = radius;
            }

            public double Area()
            {
                return Math.PI * radius * radius;
            }

            public double Perimeter()
            {
                return 2 * Math.PI * radius;
            }

            public string GetName()
            {
                return "Окружность";
            }

            public string GetParams()
            {
                return $"Радиус: {radius}";
            }
        }


    }
}
