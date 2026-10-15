using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MutafRA.Sprint1.Task2.V6.Lib;

namespace Tyuiu.MutafRA.Sprint1.Task2.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.TravelCost(67, 8.5, 6.5);
            Assert.AreEqual(74.035, res, 0.001);
        }
    }
}