using Tyuiu.GilevaAP.Sprint2.Task6.V11.Lib;
namespace Tyuiu.GilevaAP.Sprint2.Task6.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Example()
        {
            DataService ds = new DataService();
            int g = 2016;
            int m = 3;
            int n = 31;
            string wait = "2016.01.04";

            string actual = ds.FindDateOfNextDay(g, m, n);

            Assert.AreEqual(wait, actual);
        }
    }
}
