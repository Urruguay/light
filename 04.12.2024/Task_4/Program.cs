using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("***Компьютерный практикум № 2 (12.04.2024 г.)***");
            WriteLine("***Task -- 4***\n");

            Human human = new Human();
            human.TalkLoud("Я люблю программирование!");

            human.Think("A С# больше всего");

            human.TalkNormal("Меньше люблю компьютерные игры");

            Read();
        }
        interface IThinking
        {
            void Think(string thinks);
        }
        interface ITalk
        {
            void TalkLoud(string message);
            void TalkNormal(string message);
        }
        class Human : IThinking, ITalk
        {
            public void Think(string thinks)
            {
                WriteLine($"Думает - {thinks}");
            }
            public void TalkLoud(string message)
            {
                WriteLine($"Говорит громко - {message}");
            }
            public void TalkNormal(string message)
            {
                WriteLine($"Говорит норамльно - {message}");
            }
        }
    }
}
