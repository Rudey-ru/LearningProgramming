using System;
using System.Globalization;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 1. Напишите программу, вычисляющую среднее арифметическое двух чисел(ввод с консоли) 

            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };

            Console.WriteLine("Введите первое число: ");
            double a = Convert.ToDouble(Console.ReadLine(), numberFormatInfo);

            Console.WriteLine("Введите второе число: ");
            double b = Convert.ToDouble(Console.ReadLine(), numberFormatInfo);

            double result = (a + b) / 2;

            Console.WriteLine("Среднее арифметическое: " + result);
        }
    }
}
