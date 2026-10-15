using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MutafRA.Sprint1.Task2.V6.Lib
{
    public class DataService : ISprint1Task2V6
    {
        public double ConvertMToKm(int value)
        {
            throw new NotImplementedException();
        }

        public double TravelCost(double distance, double consumption, double price)
        {
            return Math.Round(
                (distance * 2 * consumption / 100) * price,
                3);
        }
    }
}
