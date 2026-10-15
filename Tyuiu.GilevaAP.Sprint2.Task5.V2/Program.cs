using Tyuiu.GilevaAP.Sprint2.Task5.V2.Lib;
namespace Tyuiu.GilevaAP.Sprint2.Task5.V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("Введите номер месяца: ");
            int numbuth = Convert.ToInt32(Console.ReadLine());

            string res;
            if ((numbuth < 1) || (numbuth > 12))
            {
                res = "Веденно неверное значение!";
            }
            else 
            {
                res = "Этот сезон: "+ds.FindMonthSeason(numbuth);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
