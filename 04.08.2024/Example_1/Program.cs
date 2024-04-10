using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Example_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("***Изучение интерфейсов. Пример1***\n");
            MyClass myClassOb = new MyClass();
            myClassOb.Show();
            Read();
        }

        interface IMyInterface
        {
            void Show();
        }

        class MyClass : IMyInterface
        {
            public void Show() 
            {
                WriteLine("MyClass.Show() is implemented (реализован)");
            }
        }

    }
}
