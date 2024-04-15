using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("***Компьютерный практикум № 2 (12.04.2024 г.)***");
            WriteLine("***Task -- 3***\n");

            DerivedClass dClass = new DerivedClass();
            dClass.Method1();
            dClass.Method2();
            dClass.Method3();
            Read();
        }
        interface IInterface1
        {
            void Method1();
        }
        interface IInterface2 : IInterface1
        {
            void Method2();
        }
        interface IInterface3 : IInterface2
        {
            void Method3();
        }
        class DerivedClass : IInterface3
        {
            public void Method1()
            {
                WriteLine("Метод Method1");
            }
            public void Method2()
            {
                WriteLine("Метод Method2");
            }
            public void Method3()
            {
                WriteLine("Метод Method3");
            }
        }
    }
}
