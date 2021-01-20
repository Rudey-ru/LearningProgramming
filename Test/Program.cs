﻿using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Этот калькулятор умеет выполнять операции над двумя числами.");

            Console.WriteLine("Введите первое число: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите знак операции, которую хотите произвести. Пример: + - * / %");
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    {
                        double res = a + b;
                        Console.WriteLine(a + " + " + b + " = " + res);
                    }           
                    
                    break;

                case "-":
                    {
                        double res = a - b;
                        Console.WriteLine(a + " - " + b + " = " + res);
                    }
                    break;

                case "*":
                    {
                        double res = a * b;
                        Console.WriteLine(a + " * " + b + " = " + res);
                    }
                    break;

                case "/":
                    {
                        if (b == 0)
                        {
                            Console.WriteLine("На ноль делить нельзя.");
                        }
                        else
                        {
                            double res = a / b;
                            Console.WriteLine(a + " / " + b + " = " + res);
                        }
                    }
                    break;

                case "%":
                    {
                        double res = a % b;
                        Console.WriteLine(a + " % " + b + " = " + res);
                    }
                    break;

                default:
                    Console.WriteLine("Вы ввели некорректный оператор.");
                    break;
            }
        }
    }
}
