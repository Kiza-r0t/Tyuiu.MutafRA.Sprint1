using Tyuiu.MutafRA.Sprint1.Task1.V19.Lib;
namespace Tyuiu.MutafRA.Sprint1.TaskX.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate(2, 3);
            Assert.AreEqual(5.3333, res, 0.0001);
        }
    }
}