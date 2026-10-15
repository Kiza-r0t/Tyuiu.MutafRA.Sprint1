
using System;
using Tyuiu.MutafRA.Sprint1.Task7.V7.Lib;
namespace Tyuiu.MutafRA.Sprint1.Task7.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(-9.288, res, 0.001);
        }
    }
}
