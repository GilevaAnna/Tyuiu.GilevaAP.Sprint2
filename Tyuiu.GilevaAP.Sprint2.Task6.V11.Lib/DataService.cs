using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.GilevaAP.Sprint2.Task6.V11.Lib
{
    public class DataService : ISprint2Task6V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            int days = m switch
            {
                1 => 31,  // Январь
                2 => 28,  // Февраль (год по условию невисокосный)
                3 => 31,  // Март
                4 => 30,  // Апрель
                5 => 31,  // Май
                6 => 30,  // Июнь
                7 => 31,  // Июль
                8 => 31,  // Август
                9 => 30,  // Сентябрь
                10 => 31, // Октябрь
                11 => 30, // Ноябрь
                12 => 31, // Декабрь
                _ => 0    // Если месяц введен неверно
            };
            if (days == 0 || n < 1 || n > days || m < 1 || m > 12 || g < 1)
            {
                return "Ошибка: Введены некорректные данные!";
            }
            int nextN = n + 1;
            int nextM = m;
            int nextG = g;

            if (nextN > days)
            {
                nextN = 1;
                nextM++;

                if (nextM > 12)
                {
                    nextM = 1;
                    nextG++;
                }
            }

            return $"{nextN:D2}.{nextM:D2}.{nextG}.";
        }
    }
}