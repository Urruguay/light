using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
//                Задание на пятницу
// Описать интерфейс для геометрических фигур, описать методы
// 1метод - метод возвращающий площадь
// 2метод - метод возвращающий периметр
// Описать классы прямоугольника, треугольника и окружности реализующие этот интерфейс,
// у всех прооизводных классов должны быть методы вычисления периметра и площади.
// Кроме этого в производных классах необходимо переопределить метод
// возвращающий строковое название фигуры и ее парметры.
// Параметры фигур должны создаваться при создании экземпляра класса.

namespace Example_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("***Exploring Interfaces.Example -- 3***\n");
            MyClass myClassOb = new MyClass();
            myClassOb.ShowA();
            myClassOb.ShowB();
            Read();
        }

        interface IMyInterfaceA
        {
            void ShowA();
        }
        interface IMyInterfaceB 
        {
            void ShowB();
        }
        class MyClass : IMyInterfaceA, IMyInterfaceB
        {
            public void ShowA() 
            {
                WriteLine("MyClass.ShowA() is completed");
            }
            public void ShowB() 
            {
                WriteLine("MyClass.ShowB() is completed");
            }
        }
    }
}
