using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Point<T>
    {
        private T x;
        private T y;

        public Point() { }
        public Point(T x, T y) 
        {
            this.x = x;
            this.y = y;
        }

        public T X
        { get { return x; } set { value = x; } }
        public T Y
        { get { return y; } set { value = y; } }

        public void Info()
        {
            Console.WriteLine($"Значение x = {X}\nЗначение y = {Y}\n");
        }
    }
}
