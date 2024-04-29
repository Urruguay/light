using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Triangle<T>
    {
        private T sideA;
        private T sideB;
        private T sideC;

        public T SideA
        {
            get { return sideA; }
            set { sideA = value; }
        }
        public T SideB
        {
            get { return sideB; }
            set { sideB = value; }
        }
        public T SideC
        {
            get { return sideC; }
            set { sideC = value; }
        }
        public Triangle() { }
        public Triangle(T sideA, T sideB, T sideC)
        {
            this.SideA = sideA;
            this.SideB = sideB;
            this.SideC = sideC;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"\nSideA - {sideA}\nSideB - {sideB}\nSideC - {sideC}\n");
        }
        public double Area()
        {
            double a = Convert.ToDouble(sideA);
            double b = Convert.ToDouble(sideB);
            double c = Convert.ToDouble(sideC);
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
    }
}
