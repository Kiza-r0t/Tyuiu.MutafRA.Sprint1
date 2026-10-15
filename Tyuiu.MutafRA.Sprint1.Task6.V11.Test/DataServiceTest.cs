using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MutafRA.Sprint1.TaskX.V11.Lib;

namespace Tyuiu.MutafRA.Sprint1.TaskX.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();
            var res = ds.CheckeFirstLetterRepetition("абракадабра");
            Assert.AreEqual(true, res);
        }
    }
}
