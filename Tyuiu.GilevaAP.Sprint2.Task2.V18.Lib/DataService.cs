using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GilevaAP.Sprint2.Task2.V18.Lib
{
    public class DataService : ISprint2Task2V18
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;
            if (x == 2)
            {
                return (y == 6 || y == 7);
            }
            else if ((x >= 3) && (x <= 5))
            {
                return ((y >= 3 && x <= 7) || (y == 11));
            }
            else if (x == 6)
            {
                return (y >= 5 && y <= 11);
            }
            else if (x == 7)
            {
                return (y >= 5 && y <= 12);
            }
            else if (x == 8)
            {
                return (y >= 5 && y <= 9);
            }
            else if ((x >= 9) && (x <= 10))
            {
                return (y >= 8 && y <= 9);
            }
            else if (x == 11)
            {
                return (y >= 8 && y <= 11);
            }
            else if (x == 12)
            {
                return (y >= 3 && y <= 11);
            }
            else if (x == 13)
            {
                return (y >= 6 && y <= 8);
            }
            
            return false;
            
        }
    }
}
