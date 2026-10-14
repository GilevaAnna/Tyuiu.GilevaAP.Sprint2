using Tyuiu.GilevaAP.Sprint2.Task3.V26.Lib;
namespace Tyuiu.GilevaAP.Sprint2.Task3.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Exemple1()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            double wait = 4.702;
            Assert.AreEqual(wait, res);
        }
        public void Exemple2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 1.667;
            Assert.AreEqual(wait, res);
        }
        public void Exemple3()
        {
            DataService ds = new DataService();
            double x = -10;
            double res = ds.Calculate(x);
            double wait = 6.535;
            Assert.AreEqual(wait, res);
        }
        public void Exemple4()
        {
            DataService ds = new DataService();
            double x = -40;
            double res = ds.Calculate(x);
            double wait = -319.975;
            Assert.AreEqual(wait, res);
        }
    }
}
