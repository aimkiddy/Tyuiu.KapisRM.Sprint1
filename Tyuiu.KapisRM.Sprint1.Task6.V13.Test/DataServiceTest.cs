using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KapisRM.Sprint1.Task6.V13.Lib;

namespace Tyuiu.KapisRM.Sprint1.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string str = "abcde";

            var res = ds.CheckWordsAlphabet(str);

            Assert.AreEqual(true, res);
        }
    }
}