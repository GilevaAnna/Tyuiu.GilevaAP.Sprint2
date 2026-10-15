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
            Assert.AreEqual("Зима", ds.FindMonthSeason(1));
            Assert.AreEqual("Лето", ds.FindMonthSeason(7));
            Assert.AreEqual("Весна", ds.FindMonthSeason(3));
            Assert.AreEqual("Осень", ds.FindMonthSeason(9));


            Assert.ThrowsExactly<ArgumentException>(() => { ds.FindMonthSeason(-1);});

            Assert.Throws<ArgumentException>(() => { ds.FindMonthSeason(13); });
        }
    }
}
