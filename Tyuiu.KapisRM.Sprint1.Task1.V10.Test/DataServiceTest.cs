namespace Tyuiu.KapisRM.Sprint1.Task1.V10.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Tyuiu.KapisRM.Sprint1.Task1.V10.Lib;

    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckCalcValid()
        {
            DataService ds = new DataService();

            double x = 2;
            double y = 4;
            double wait = 2.0;

            double res = ds.Calculate(x, y);

            Assert.AreEqual(wait, res);
        }
    }
}
