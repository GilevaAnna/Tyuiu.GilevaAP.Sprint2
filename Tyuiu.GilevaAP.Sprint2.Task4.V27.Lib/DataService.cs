using tyuiu.cources.programming.interfaces.Sprint2;
using Tyuiu.GilevaAP.Sprint2.Task4.V27.Lib;
namespace Tyuiu.GilevaAP.Sprint2.Task4.V27.Lib
{
    public class DataService : ISprint2Task4V27
    {
        public double Calculate(double x, double y)
        {
            var xy = ((y + 2) / (x - 1));
            var xy2 = Math.Pow((xy), x);
            var y2 = Math.Pow(y, 2);

            double z = ((x - 10) > (y + 2)) ? (x * xy2) : (y2 - (2 / x));
            return Math.Round(z, 3);
        }
    }
}
