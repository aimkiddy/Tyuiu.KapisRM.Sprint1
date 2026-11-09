using System;


using Tyuiu.KapisRM.Sprint1.Task0.V18.Lib;
namespace Tyuiu.KapisRM.Sprint1.Task0.V18.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void TestMethod1()
        { }
            public class DataServiceTest
        {
            [TestMethod]
            public void ValidExpression()
            {
                DataService ds = new DataService();
                int[] nums1 = new int[] { 9, 6, 2, 3, 9, 3 };
                int[] nums2 = new int[] { 9, 6, 2, 3, 9, 3 };

                double res = ds.Calculate();
                int wait = 3;

                Assert.AreEqual(wait, res);
            }
        }
    }

}
    
