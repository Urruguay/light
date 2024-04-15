using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("***Компьютерный практикум № 2 (12.04.2024 г.)***");
            WriteLine("***Task -- 5***\n");

            // Создание списка для хранения объектов
            List<ISwitchable> devices = new List<ISwitchable>();

            // Добавление объектов в список
            devices.Add(new TVSet());
            devices.Add(new PersonalComputer());

            // Вызов методов включения и выключения для каждого объекта в списке
            foreach (var device in devices)
            {
                device.TurnOn();
                device.TurnOff();
                WriteLine();
            }

            Read();
        }
        interface ISwitchable
        {
            void TurnOn();
            void TurnOff();
        }
        class TVSet : ISwitchable
        {
            public void TurnOn()
            {
                WriteLine("Телевизор включен");
            }
            public void TurnOff()
            {
                WriteLine("Телевизор выключен");
            }
        }
        class PersonalComputer : ISwitchable
        {
            public void TurnOn()
            {
                WriteLine("Компьютер включен");
            }
            public void TurnOff()
            {
                WriteLine("Компьютер выключен");
            }
        }
    }
}
