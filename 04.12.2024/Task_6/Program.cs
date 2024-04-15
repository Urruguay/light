using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("***Компьютерный практикум № 2 (12.04.2024 г.)***");
            WriteLine("***Task -- 6***\n");
            again:
            Ab calculator = new Ab();

            try
            {
                Write("Введите число (x): ");
                double x = Convert.ToDouble(ReadLine());

                Write("Введите операцию: ");
                string operation = ReadLine();

                double result;
                if (operation == "^" || operation == "sqrt")
                {
                    result = calculator.PerformOperation(x,operation);
                    WriteLine($"Результат операции {operation} {x} = {result}");
                }
                else
                {
                    Write("Введите второе число (y): ");
                    double y = Convert.ToDouble(ReadLine());

                    result = calculator.PerformOperation(x, operation, y);
                    WriteLine($"Результат {x} {operation} {y} = {result}");
                }
            }
            catch (FormatException)
            {
                WriteLine("Неверный формат ввода. Пожалуйста, введите корректные числа.");
            }
            catch (DivideByZeroException)
            {
                WriteLine("Деление на ноль невозможно.");
            }
            catch (ArgumentException ex)
            {
                WriteLine(ex.Message);
            }
            catch (Exception)
            {
                WriteLine("Произошла ошибка.");
            }
            goto again;
        
        }
        interface IArifmOp
        {
            double Add(double x, double y);
            double Sub(double x, double y);
            double Multiply(double x, double y);
            double Divide(double x, double y);
        }
        interface IArifmSqrt
        {
            double Square(double x);
            double SqrtRoot(double x);
        }
        class A : IArifmOp
        {
            public virtual double Add(double x, double y)
            {
                return x + y;
            }
            public virtual double Sub(double x, double y) 
            {
                return x - y;
            }
            public virtual double Multiply(double x, double y)
            {
                return x * y; 
            }
            public virtual double Divide(double x, double y) 
            {
                if (y == 0)
                {
                    WriteLine("На ноль делить нельзя");
                }
                
                return x / y;
            }
        }
        class Aa : A, IArifmOp
        {
            public override double Add(double y, double x) // Обратный порядок аргументов
            {
                return y + x;
            }
            public override double Sub(double y, double x) // Обратный порядок аргументов ...
            {
                return y - x;
            }
            public override double Multiply(double y, double x)
            {
                return y * x;
            }
            public override double Divide(double y, double x)
            {
                if (x == 0)
                {
                    WriteLine("На ноль делить нельзя");
                }
                return y / x;
            }
        }
        class Ab : A, IArifmSqrt
        {
            public double PerformOperation(double x, string operation, double y = 0)
            {
                switch (operation)
                {
                    case "+":
                        return Add(x, y);
                    case "-":
                        return Sub(x, y);
                    case "*":
                        return Multiply(x, y);
                    case "/":
                        return Divide(x, y);
                    case "^":
                        return Square(x);
                    case "sqrt":
                        return SqrtRoot(x);
                    default:
                        WriteLine("Invalid operation.");
                        return 0;
                }
            }
            public double Square(double x)
            {
                return Math.Pow(x, 2);
            }
            public double  SqrtRoot(double x)
            {
                if (x < 0)
                {
                    WriteLine("Не существует квадратного корня из отрицательного числа");
                }
                return Math.Sqrt(x);
            }
        }
    }
}
