using System;
using System.Globalization;

namespace HW2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 2. Введите три числа и выведите на экран значение суммы и произведения этих чисел 

            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };

            Console.WriteLine("Введите первое число: ");
            double a = Convert.ToDouble(Console.ReadLine(), numberFormatInfo);

            Console.WriteLine("Введите второе число: ");
            double b = Convert.ToDouble(Console.ReadLine(), numberFormatInfo);

            Console.WriteLine("Введите третье число: ");
            double c = Convert.ToDouble(Console.ReadLine(), numberFormatInfo);

            double sumRes = a + b + c;
            Console.WriteLine("Сумма трех чисел: " + sumRes);

            double multipRes = a * b * c;
            Console.WriteLine("Произведение трех чисел: " + multipRes);
        }
    }
}
