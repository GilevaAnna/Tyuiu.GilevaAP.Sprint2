using Tyuiu.GilevaAP.Sprint2.Task4.V27.Lib;
namespace Tyuiu.GilevaAP.Sprint2.Task4.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Example1()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = -8;
            double res = ds.Calculate(x, y);
            double wait = -37.969;
            Assert.AreEqual(wait, res);
        }
        public void Example2()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = 3.6;
            Assert.AreEqual(wait, res);
        }
    }
}
using Tyuiu.GilevaAP.Sprint2.Task4.V27.Lib;
namespace Tyuiu.GilevaAP.Sprint2.Task4.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("Введите значение переменной X:");
            double x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите значение переменной Y:");
            double y = Convert.ToInt32(Console.ReadLine());

            double res = ds.Calculate(x, y);


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Значение функции = " + res);
            Console.ReadKey();
        }
    }
}