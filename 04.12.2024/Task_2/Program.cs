using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("***Компьютерный практикум № 2 (12.04.2024 г.)***");
            WriteLine("***Task -- 2***\n");
            MyClass myClass = new MyClass();
            WriteLine($"Число Пи - {myClass.RetPI()}");
            WriteLine($"Число типа int - {myClass.RetInt()}");
            WriteLine($"X^2 - {myClass.RetSquared(5)}");
            WriteLine($"Корень квадратный X - {myClass.RetSquaredRoot(25)}");
            Read();
        }
        interface ICalc
        {
            double RetPI();
            int RetInt();
            double RetSquared(double x);
            double RetSquaredRoot(int x);
        }
        class MyClass : ICalc
        {
            public double RetPI()
            {
                return Math.PI;
            }
            public int RetInt()
            {
                return 25;
            }
            public double RetSquared(double x)
            {
                return Math.Pow(x, 2);
            }
            public double RetSquaredRoot(int x)
            {
                return Math.Sqrt(x);
            }
        }
    }
}
