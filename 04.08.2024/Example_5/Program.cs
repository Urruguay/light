using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Example_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("***Exploring Interfaces.Example -- 5***");
            WriteLine("***Concept of multiple inheriyance through interface***\n");
            MyClass myClassOb = new MyClass();
            myClassOb.ShowInterfaceA();
            myClassOb.ShowInterfaceB();
            myClassOb.ShowInterfaceC();
            
            Read();
        }

        interface InterfaceA
        {
            void ShowInterfaceA();
        }
        interface InterfaceB
        {
            void ShowInterfaceB();
        }
        interface InterfaceC : InterfaceA, InterfaceB
        {
            void ShowInterfaceC();
        }
        class MyClass : InterfaceC
        {
            public void ShowInterfaceA()
            {
                WriteLine("ShowInterfaceA() is completed");
            }
            public void ShowInterfaceB()
            {
                WriteLine("ShowInterfaceB() is completed");
            }
            public void ShowInterfaceC()
            {
                WriteLine("ShowInterfaceC() is completed");
            }
        }
    }
}
