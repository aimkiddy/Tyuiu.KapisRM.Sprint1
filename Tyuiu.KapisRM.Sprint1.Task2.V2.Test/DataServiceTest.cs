using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KapisRM.Sprint1.Task2.V2.Lib;

namespace Tyuiu.KapisRM.Sprint1.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int value = 180;
            double wait = 3.142;
            double res = ds.ConvertAngleToRad(value);
            Assert.AreEqual(wait, res);
        }
    }
}