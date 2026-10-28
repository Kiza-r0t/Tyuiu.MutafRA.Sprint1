using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MutafRA.Sprint1.Task3.V6.Lib;

namespace Tyuiu.MutafRA.Sprint1.Task3.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidTravelCost()
        {
            DataService ds = new DataService();
            double distance = 67;
            double gasFlow = 8.5;
            double gasPrice = 6.5;

            double res = ds.TravelCost(distance, gasFlow, gasPrice);
            Assert.AreEqual(74.035, res, 0.001);
        }
    }
}