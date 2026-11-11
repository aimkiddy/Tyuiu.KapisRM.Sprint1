using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KapisRM.Sprint1.Task3.V6.Lib;

namespace Tyuiu.KapisRM.Sprint1.Task3.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double distance = 67;
            double consumption = 8.5;
            double price = 6.5;
            var res = ds.Calculate(distance, consumption, price);
            Assert.AreEqual(74.035, res);
        }
    }
}