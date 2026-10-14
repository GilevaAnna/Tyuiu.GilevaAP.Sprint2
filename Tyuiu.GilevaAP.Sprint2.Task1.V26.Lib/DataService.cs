using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GilevaAP.Sprint2.Task1.V26.Lib
{
    public class DataService : ISprint2Task1V26
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a!=b)|(c==d); //t
            res[1] = (a<b)&(c>d); //t
            res[2] = (a>=b)||(c>d); //t
            res[3] = (c==b)&&(a>=d); //f
            res[4] = !(res[3]); //t
            res[5] = (d<b)^(c!=a); //f
            return res;
        }
    }
}
