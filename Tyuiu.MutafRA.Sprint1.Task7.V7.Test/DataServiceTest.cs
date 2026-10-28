using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MutafRA.Sprint1.Task7.V7.Lib;

namespace Tyuiu.MutafRA.Sprint1.Task7.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            double x = 1;
            double y = 2;

            double res = ds.Calculate(x, y);

            // Ожидаемый результат: -9.288
            Assert.AreEqual(-9.288, res, 0.001);
        }
    }
}