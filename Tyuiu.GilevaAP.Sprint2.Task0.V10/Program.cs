using Tyuiu.GilevaAP.Sprint2.Task0.V10.Lib;
namespace Tyuiu.GilevaAP.Sprint2.Task0.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int x = 1305;
            int y = 475;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("X = " + x);
            Console.WriteLine("Y = " + y);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }

            Console.ReadKey();
        }
    }
}