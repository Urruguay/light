using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("***Компьютерный практикум №2 (12.04.2024г.)***");
            WriteLine("***Task -- 1***\n");
            DerivedClass dClass = new DerivedClass();
            dClass.Method();
            IInterface interface1 = new DerivedClass();
            interface1.Method();
            Read();
        }

        interface IInterface
        {
            void Method();
        }
        class DerivedClass : IInterface
        {
            public void Method()
            {
                WriteLine("Метод, реалищованный в классе DerivedClass");
            }
        }
    }
}
