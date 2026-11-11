using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KapisRM.Sprint1.Task5.V7.Lib;

namespace Tyuiu.KapisRM.Sprint1.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double f = 90.0; 
            var res = ds.AngleToHoursMinutes(f);
            Assert.AreEqual(3, res);
        }
    }
}