using Tyuiu.GilevaAP.Sprint2.Task5.V2.Lib;
namespace Tyuiu.GilevaAP.Sprint2.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Example()
        {
            DataService ds = new DataService();
            Assert.AreEqual("зима", ds.FindMonthSeason(1));
            Assert.AreEqual("лето", ds.FindMonthSeason(7));
            Assert.AreEqual("весна", ds.FindMonthSeason(3));
            Assert.AreEqual("осень", ds.FindMonthSeason(9));


            Assert.ThrowsExactly<ArgumentException>(() => { ds.FindMonthSeason(-1);});

            Assert.Throws<ArgumentException>(() => { ds.FindMonthSeason(13); });
        }
    }
}
