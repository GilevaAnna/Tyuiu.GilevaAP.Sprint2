using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GilevaAP.Sprint2.Task0.V10.Lib
{
    public class DataService : ISprint2Task0V10
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            res[0] = x == y; //f
            res[1] = x != y; //t
            res[2] = x < y; //f
            res[3] = x > y; //t
            res[4] = x <= y; //f
            res[5] = x >= y; //t
            return res;
        }
    }
}
