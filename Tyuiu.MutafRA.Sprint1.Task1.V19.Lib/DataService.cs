using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.MutafRA.Sprint1.Task1.V19.Lib
{
    public class DataService : ISprint1Task1V19
    {
        public double Calculate(double x, double y)
        {
            return (x + 10 * y) / (x * y);
        }
    }
}