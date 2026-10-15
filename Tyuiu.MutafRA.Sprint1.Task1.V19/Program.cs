using System;
using Tyuiu.MutafRA.Sprint1.Task1.V19.Lib;
namespace Tyuiu.MutafRA.Sprint1.TaskX.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Мутаф Р. А. | АСОиУБ-26-1";
            //Длина строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Мутаф Роман Александрович | АСОиУБ-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* вычисляет результат по формуле (x + 10*y) / (x*y)                       *");
            Console.WriteLine("* и печатает его на экране.                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double x, y;

            Console.Write("Введите значение X: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение Y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            if (x == 0 || y == 0)
            {
                Console.WriteLine("Ошибка: x и y не могут быть равны 0 (деление на ноль)");
            }
            else
            {
                double res = ds.Calculate(x, y);
                Console.WriteLine($"(x + 10*y) / (x*y) = {res}");
            }

            Console.ReadKey();
        }
    }
}