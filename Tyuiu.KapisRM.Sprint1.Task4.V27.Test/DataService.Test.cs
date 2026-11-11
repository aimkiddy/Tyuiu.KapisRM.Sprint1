using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KapisRM.Sprint1.Task4.V27.Lib;

namespace Tyuiu.KapisRM.Sprint1.Task4.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2.0;
            double y = 1.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1 , res);
        }
    }
}