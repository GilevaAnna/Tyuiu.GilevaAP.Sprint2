using Tyuiu.GilevaAP.Sprint2.Task0.V10.Lib;
namespace Tyuiu.GilevaAP.Sprint2.Task0.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Exampl()
        {
            DataService ds = new DataService();
            int x = 30;
            int y = 2;
            bool[] res = new bool[6];
            res =ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] { false, true, false, true, false, true };
            CollectionAssert.AreEqual(res, wait);
        }
    }
}
