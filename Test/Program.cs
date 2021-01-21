using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.Clear();

                double a, b;

                Console.WriteLine("Этот калькулятор умеет выполнять операции над двумя числами.");

                try
                {
                    Console.WriteLine("Введите первое число: ");
                    a = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введите второе число: ");
                    b = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception)
                {

                    Console.WriteLine("Введите корректные данные.");
                    Console.ReadLine();
                    continue;
                }

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

                Console.ReadLine();
            }
        }
    }
}
