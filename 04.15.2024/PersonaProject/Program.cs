using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PersonaProject
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("***Компьютерный практикум № 3 (15.04.2024 г.)***");
            WriteLine("***Task -- 2***\n");

            List<Person> people = new List<Person>();
            {
                people.Add(new Person("Яна", 25));
                people.Add(new Person("Андрей", 13));
                people.Add(new Person("Максим", 17));
            };
            WriteLine("Неотсортированный:");
            foreach (var person in people)
            {
                WriteLine($"Имя - {person.Name}\n Возраст: {person.Age}");
            }
            WriteLine("\nОтсортированный:");
            people.Sort();
            foreach (var person in people)
            {
                WriteLine($"Имя - {person.Name}\n Возраст: {person.Age}");
            }
            Read();
        }
    }
}
