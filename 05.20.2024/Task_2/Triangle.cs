using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Triangle<K>
    {
        public K a; public K b; public K c;

        public K A
        {
            get { return a; }
            set { a = value; }
        }
        public K B
        {
            get { return b; }
            set { b = value; }
        }
        public K C
        {
            get { return c; }
            set { c = value; }
        }
        public Triangle() { }
        public Triangle(K a, K b, K c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        
        public dynamic Area()
        {
            dynamic a1 = A;
            dynamic b1 = B;
            dynamic c1 = C;
            dynamic p = (a1 + b1 + c1) / 2;
            if (a1 == 0 && b1 == 0 && c1 == 0)
            {
                Console.WriteLine("Такого не существует:");
            }
             return Math.Sqrt(p * (p - a1) * (p - b1) * (p - c1));
            
            
        }

        public void Info()
        {
            Console.WriteLine($"Сторона a = {A}\nСторона b = {B}\nСторона c = {C}");
        }
    }
}
