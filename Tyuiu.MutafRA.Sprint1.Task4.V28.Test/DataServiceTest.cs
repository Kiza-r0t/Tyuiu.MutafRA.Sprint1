using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MutafRA.Sprint1.Task4.V28.Lib;

namespace Tyuiu.MutafRA.Sprint1.Task4.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            double x = 1;
            double y = 1;

            double res = ds.Calculate(x, y);
            Assert.AreEqual(0.05, res, 0.001);
        }
    }
}