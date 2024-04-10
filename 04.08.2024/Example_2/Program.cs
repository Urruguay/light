using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Example_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("***Изучение интерфейсов. Пример1***\n");
            MyClass myOb = new ChildClass();
            myOb.Show1();
            myOb.Show2();
            Read();
        }

        interface IMyInterface
        {
            void Show1();
            void Show2();
        }

        abstract class MyClass : IMyInterface
        {
            public void Show1()
            {
                WriteLine("MyClass.Show1() is implemented (реализован)");
            }
            public abstract void Show2();
        }
        class ChildClass : MyClass
        {
            public override void Show2()
            {
                WriteLine("ChildClass is complpeting -- Show2()");
            }
        }
    }
}
