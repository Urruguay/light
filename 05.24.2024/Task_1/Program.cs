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
        enum Month
        {
           Январь, Февраль, Март, Апрель, Май, Июнь, Июль, Август, Сентябрь, Октябрь, Ноябрь, Декабрь
        }
        enum Days
        {
            Sat, Sun, Mon, Tue, Wed, Thu, Fri
        }
        enum MathOperation
        {
            Сложение, Вычитание, Умножение, Деление, Выход
        }
        static void Main(string[] args)
        {
            //Task_1

            //1
            //WriteLine($"{(int)Month.Январь}\t{Month.Январь}");
            //WriteLine($"{(int)Month.Февраль}\t{Month.Февраль}");
            //WriteLine($"{(int)Month.Март}\t{Month.Март}");
            //WriteLine($"{(int)Month.Апрель}\t{Month.Апрель}");
            //WriteLine($"{(int)Month.Май}\t{Month.Май}");
            //WriteLine($"{(int)Month.Июнь}\t{Month.Июнь}");
            //WriteLine($"{(int)Month.Июль}\t{Month.Июль}");
            //WriteLine($"{(int)Month.Август}\t{Month.Август}");
            //WriteLine($"{(int)Month.Сентябрь}\t{Month.Сентябрь}");
            //WriteLine($"{(int)Month.Октябрь}\t{Month.Октябрь}");
            //WriteLine($"{(int)Month.Ноябрь}\t{Month.Ноябрь}");
            //WriteLine($"{(int)Month.Декабрь}\t{Month.Декабрь}");

            //2
            //Month m;
            //for (m = Month.Январь; m < Month.Декабрь; m++)
            //{
            //    WriteLine($"{(int)m}\t{m}");
            //}

            //Task_2

            //Days i;
            //for (i = Days.Sat; i <= Days.Fri; i++)
            //{
            //    WriteLine(i + " имеет значение " + (int)i);
            //}

            //Task_3

            WriteLine("Введите два числа:");
            Write("Число 1 —— ");
            double num1 = double.Parse(ReadLine());
            Write("Число 2 —— ");
            double num2 = double.Parse(ReadLine());
            double result;

            foreach (MathOperation op in Enum.GetValues(typeof(MathOperation)))
            {
                switch (op)
                {
                    case MathOperation.Сложение:
                        result = num1 + num2;
                        WriteLine($"Сложение: {num1} + {num2} = {result}");
                        break;

                    case MathOperation.Вычитание:
                        result = num1 - num2;
                        WriteLine($"Вычитание: {num1} - {num2} = {result}");
                        break;

                    case MathOperation.Умножение:
                        result = num1 * num2;
                        WriteLine($"Умножение: {num1} * {num2} = {result}");
                        break;

                    case MathOperation.Деление:
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                            WriteLine($"Деление: {num1} / {num2} = {result:f2}");
                        }
                        else
                        {
                            WriteLine("Деление на ноль невозможно.");
                        }
                        break;
                }
            }

                Read();
        }
    }
}
