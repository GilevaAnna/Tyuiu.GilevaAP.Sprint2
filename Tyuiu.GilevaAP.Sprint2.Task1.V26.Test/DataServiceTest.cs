using Tyuiu.GilevaAP.Sprint2.Task1.V26.Lib;
namespace Tyuiu.GilevaAP.Sprint2.Task1.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Example()
        {
            DataService ds = new DataService();
            int a = 2;
            int b = 3;
            int c = 4;
            int d = 1;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] { true, true, true, false, true, false };
            CollectionAssert.AreEqual(res, wait);
        }
    }
}
