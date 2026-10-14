using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GilevaAP.Sprint2.Task2.V18.Lib
{
    public class DataService : ISprint2Task2V18
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            if (y == 2)
            {
                return (x == 6 || x == 7);
            }
            else if ((y >= 3) && (y <= 5))
            {
                return ((x >= 3 && x <= 7) || (x == 11));
            }
            else if (y == 6)
            {
                return (x >= 5 && x <= 11);
            }
            else if (y == 7)
            {
                return (x >= 5 && x <= 12);
            }
            else if (y == 8)
            {
                return (x >= 5 && x <= 9);
            }
            else if ((y >= 9) && (y <= 10))
            {
                return (x >= 8 && x <= 9);
            }
            else if (y == 11)
            {
                return (x >= 8 && x <= 11);
            }
            else if (y == 12)
            {
                return (x >= 3 && x <= 11);
            }
            else if (y == 13)
            {
                return (x >= 6 && x <= 8);
            }
            
            return false;
            
        }
    }
}
