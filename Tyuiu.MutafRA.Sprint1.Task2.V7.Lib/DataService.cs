using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MutafRA.Sprint1.Task2.V7.Lib
{
    public class DataService : ISprint1Task2V7
    {
        public double CalculateSquareCircle(int radius)
        {
            return Math.Round(Math.PI * radius * radius, 3);
        }
    }
}