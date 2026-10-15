using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MutafRA.Sprint1.Task2.V7.Lib;

namespace Tyuiu.MutafRA.Sprint1.Task2.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int radius = 5;
            var res = ds.CalculateSquareCircle(radius);
            Assert.AreEqual(78.54, res, 0.001);
        }
    }
}