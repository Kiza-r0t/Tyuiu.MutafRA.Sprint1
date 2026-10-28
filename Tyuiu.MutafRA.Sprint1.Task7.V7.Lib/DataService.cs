using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MutafRA.Sprint1.Task7.V7.Lib
{
    public class DataService : ISprint1Task7V7
    {
        public double Calculate(double x, double y)
        {

            double fraction = Math.Cos(x) / (Math.PI - 2 * Math.Pow(y, x));

            double term = 16 * x * Math.Cos(x * y);

            double z = fraction + term - 2;

            return Math.Round(z, 3);
        }
    }
}