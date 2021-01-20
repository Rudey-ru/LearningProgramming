using System;
using System.Globalization;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            // Задача 3. Напишите простой конвертер валют(без возможности динамического выбора валюты пользователем). 
            // Валюты заданы хардкором и не изменяются. Тип на выбор программиста

            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = ".",
            };

            Console.WriteLine("Перевод из UAH в USD" + "\n" + "Введите колличество валюты: ");

            double a = Convert.ToDouble(Console.ReadLine(), numberFormatInfo);

            double ResConUSD = a / 28.165;

            Console.WriteLine(a + " UAH - " + ResConUSD + " USD");

            Console.WriteLine("Перевод из USD в UAH" + "\n" + "Введите колличество валюты: ");

            double b = Convert.ToDouble(Console.ReadLine(), numberFormatInfo);

            double ResConUAH = b * 28.165;

            Console.WriteLine(b + " USD - " + ResConUAH + " UAH");

        }
    }
}