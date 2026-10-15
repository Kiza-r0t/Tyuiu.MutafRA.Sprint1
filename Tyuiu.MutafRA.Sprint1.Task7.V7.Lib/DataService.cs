using System;
using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MutafRA.Sprint1.Task7.V7.Lib
{
    public class DataService
    {
        public double Calculate(double x, double y)
        {
            double res = Math.Cos(x) / (Math.PI - 2 * Math.Pow(y, x))
                       + 16 * x * Math.Cos(x * y)
                       - 2;
            return Math.Round(res, 3);
        }
    }
}