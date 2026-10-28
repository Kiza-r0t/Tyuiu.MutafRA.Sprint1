using System;
using Tyuiu.MutafRA.Sprint1.Task3.V6.Lib;

namespace Tyuiu.MutafRA.Sprint1.Task3.V6
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
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Мутаф Роман Александрович | АСОиУБ-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу вычисления стоимости поездки на автомобиле на дачу   *");
            Console.WriteLine("* (туда и обратно). Исходные данные: расстояние, расход, цена.            *");
            Console.WriteLine("* Ответ округлить до 3 знаков после запятой.                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double distance, gasFlow, gasPrice;

            Console.Write("Введите расстояние до дачи (км): ");
            distance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите расход бензина (л на 100 км): ");
            gasFlow = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите цену литра бензина (руб.): ");
            gasPrice = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            // Вызываем метод TravelCost с новыми параметрами
            double cost = ds.TravelCost(distance, gasFlow, gasPrice);
            Console.WriteLine($"Поездка на дачу и обратно обойдется в {cost} руб.");

            Console.ReadKey();
        }
    }
}