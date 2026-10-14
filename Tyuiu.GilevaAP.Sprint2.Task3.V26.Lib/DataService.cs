using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GilevaAP.Sprint2.Task3.V26.Lib
{
    public class DataService : ISprint2Task3V26
    {
        public double Calculate(double x)
        {
            double y = 0;
            if (x > 0)
            {
                var x2 = Math.Pow(x, 2);
                var cosx = ((x + 1) / Math.Cos(x2));
                y = x + (Math.Pow(cosx, x));
            }
            else 
            {
                if (x == 0)
                {
                    var x2 = Math.Pow(x, 2);
                    y = (15 + x) / (9 - (Math.Sin(x2)));
                }
                else 
                {
                    if ((x > -30) && (x < 0))
                    {
                        var x3 = Math.Pow(x, 3);
                        var k = (Math.Sin(x3)) / (x + 5);
                        y = Math.Pow(k, x);
                    }
                    else 
                    {
                        if (x < -30)
                        {
                            y = x + 7 * x - (1 / x);
                        }
                    }
                }
            }
            var res = Math.Round(y, 3);
            return res;
        }
    }
}
