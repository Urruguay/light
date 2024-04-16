using System;

namespace Task_4
{
    /// <summary>
    /// Класс треугольника
    /// </summary>
    public class Triangle : Figure
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

        public override double Area()
        {
            // Формула Герона для вычисления площади треугольника
            double s = (side1 + side2 + side3) / 2;
            return Math.Sqrt(s * (s - side1) * (s - side2) * (s - side3));
        }

        public override double Perimeter()
        {
            return side1 + side2 + side3;
        }

        public override string GetName()
        {
            return "Треугольник";
        }

        public override string GetParams()
        {
            return $"Сторона_1: {side1}\nСторона_2: {side2}\nСторона_3: {side3}";
        }
    }
}
