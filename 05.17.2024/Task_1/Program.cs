using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyStruct myStruct;

            myClass.change = "не изменено";
            myStruct.change = "не изменено";

            ClassTaker(myClass);
            StruktTaker(myStruct);

            Console.WriteLine($"Значение поля экземпляра класса: {myClass.change}");
            Console.WriteLine($"Значение поля экземпляра структуры: {myStruct.change}");

            Console.Read();

        }

        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "изменено";
        }
        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.change = "изменено";
        }
    }
    public class MyClass
    {
        public string change;
    }
    public struct MyStruct
    {
        public string change;
    }
}
