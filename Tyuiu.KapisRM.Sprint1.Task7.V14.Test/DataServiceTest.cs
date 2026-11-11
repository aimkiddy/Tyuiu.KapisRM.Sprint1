using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KapisRM.Sprint1.Task7.V14.Lib;

namespace Tyuiu.KapisRM.Sprint1.Task7.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double a = 1.0;
            double b = 1.0;
            double c = 1.0; 
            var res = ds.Calculate(a, b, c);

            Assert.AreEqual(2.536, res);
        }
    }
}