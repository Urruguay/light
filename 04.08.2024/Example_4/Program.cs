using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Example_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("***Exploring Interfaces.Example -- 4***\n");
            MyClass myClassOb = new MyClass();
            myClassOb.Show();
            IMyInterfaceA interA = myClassOb;
            interA.Show();
            IMyInterfaceB interB = myClassOb;
            interB.Show();
            Read();
        }
        interface IMyInterfaceA
        {
            void Show();
        }
        interface IMyInterfaceB
        {
            void Show();
        }
        class MyClass : IMyInterfaceA, IMyInterfaceB
        {
            public void Show()
            {
                WriteLine("MyClass.Show() is completed");
            }
            void IMyInterfaceA.Show()
            {
                WriteLine("Explicit interface Implementation. IMyInterfaceA.Show()");
            }
            void IMyInterfaceB.Show()
            {
                WriteLine("Explicit interface Implementation. IMyInterfaceB.Show()");
            }
        }
    }
}
