using System;
using Tyuiu.MutafRA.Sprint1.Task2.V7.Lib;

namespace Tyuiu.MutafRA.Sprint1.Task2.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Мутаф Р. А. | АСОиУБ-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Мутаф Роман Александрович | АСОиУБ-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Известен радиус круга. Вычислить площадь круга.                         *");
            Console.WriteLine("* Ответ округлить до 3 знаков после запятой.                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int radius;

            Console.Write("Введите радиус круга: ");
            // Так как метод принимает int, используем Convert.ToInt32
            radius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            // Передаем int в метод
            double area = ds.CalculateSquareCircle(radius);
            Console.WriteLine($"Площадь круга = {area}");

            Console.ReadKey();
        }
    }
}