using Tyuiu.GilevaAP.Sprint2.Task7.V10.Lib;
namespace Tyuiu.GilevaAP.Sprint2.Task7.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Example()
        {
            DataService ds = new DataService();
            double x = 0;
            double y = 0;
            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
