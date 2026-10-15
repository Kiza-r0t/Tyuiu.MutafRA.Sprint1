using System;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MutafRA.Sprint1.Task4.V28.Lib
{
    public class DataService : ISprint1Task1V28
    {
        public double Calculate(double x, double y)
        {
            // Не округляем промежуточные результаты — только финал
            double numerator = Math.Cos(60.0 * Math.PI / 2.0);
            double denominator = Math.Exp(2.0 * x + y);

            // Округляем только итог
            return Math.Round(numerator / denominator, 3);
        }

        public double Calculate(double x)
        {
            throw new NotImplementedException();
        }
    }
}