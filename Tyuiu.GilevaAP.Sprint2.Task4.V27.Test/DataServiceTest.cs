using Tyuiu.GilevaAP.Sprint2.Task4.V27.Lib;
namespace Tyuiu.GilevaAP.Sprint2.Task4.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Example()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = -8;
            double res = ds.Calculate(x, y);
            double wait = -37.969;
            Assert.AreEqual(wait, res);
        }
        public void Example2()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = 3.6;
            Assert.AreEqual(wait, res);
        }
    }
}
