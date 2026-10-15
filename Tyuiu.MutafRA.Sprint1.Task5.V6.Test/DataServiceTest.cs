using System;
using Tyuiu.MutafRA.Sprint1.Task5.V6.Lib;
namespace Tyuiu.MutafRA.Sprint1.Task5.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int k = 15;
            var res = ds.Calculate(k);
            Assert.AreEqual(1, res);
        }
    }
}