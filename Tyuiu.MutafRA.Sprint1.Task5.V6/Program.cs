using System;
using Tyuiu.MutafRA.Sprint1.Task5.V6.Lib;
namespace Tyuiu.MutafRA.Sprint1.Task5.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Мутаф Р. А. | АСОиУБ-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
            Console.WriteLine("* Задание #5                                                             *");
            Console.WriteLine("* Вариант #6                                                              *");
            Console.WriteLine("* Выполнил: Мутаф Роман Александрович | АСОиУБ-26-1                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Пусть k — целое от 1 до 365. Присвоить переменной n значение 1..7       *");
            Console.WriteLine("* в зависимости от того, на какой день недели приходится k-й день          *");
            Console.WriteLine("* невисокосного года, в котором 1 января — понедельник.                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int k;
            Console.Write("Введите номер дня года k (от 1 до 365): ");
            k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int n = ds.Calculate(k);
            Console.WriteLine($"k = {k} → день недели n = {n}");
            Console.WriteLine($"({DayName(n)})");

            Console.ReadKey();
        }

        static string DayName(int n)
        {
            switch (n)
            {
                case 1: return "Понедельник";
                case 2: return "Вторник";
                case 3: return "Среда";
                case 4: return "Четверг";
                case 5: return "Пятница";
                case 6: return "Суббота";
                case 7: return "Воскресенье";
                default: return "Неизвестно";
            }
        }
    }
}