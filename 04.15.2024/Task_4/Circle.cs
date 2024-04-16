using System;

namespace Task_4
{
    /// <summary>
    /// Класс окружности
    /// </summary>
    public class Circle : Figure
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double Area()
        {
            return Math.PI * radius * radius;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * radius;
        }

        public override string GetName()
        {
            return "Окружность";
        }

        public override string GetParams()
        {
            return $"Радиус: {radius:f2}";
        }
    }
}
