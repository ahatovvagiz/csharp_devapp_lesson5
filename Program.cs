using System;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите выражение вида a + b, a - b, a / b, a * b (или пустую строку для выхода):"); string input = Console.ReadLine();


                if (string.IsNullOrEmpty(input))
                {
                    break;
                }

                string[] expression = input.Split(' ');

                if (expression.Length != 3)
                {
                    Console.WriteLine("Неверный формат ввода");
                    continue;
                }

                if (!int.TryParse(expression[0], out int a))
                {
                    Console.WriteLine("Неверно задано значение A");
                    continue;
                }
                if (!int.TryParse(expression[2], out int b))
                {
                    Console.WriteLine("Неверно задано значение B");
                    continue;
                }

                switch (expression[1])
                {
                    case "+":
                        Console.WriteLine($"{a} + {b} = {a + b}");
                        break;
                    case "-":
                        Console.WriteLine($"{a} - {b} = {a - b}");
                        break;
                    case "/":
                        if (b == 0)
                        {
                            Console.WriteLine("Деление на 0 невозможно");
                        }
                        else
                        {
                            Console.WriteLine($"{a} / {b} = {a / b}");
                        }
                        break;
                    case "*":
                        Console.WriteLine($"{a} * {b} = {a * b}");
                        break;
                    default:
                        Console.WriteLine("Неизвестная арифметическая операция");
                        break;
                }
            }
        }
    }
}