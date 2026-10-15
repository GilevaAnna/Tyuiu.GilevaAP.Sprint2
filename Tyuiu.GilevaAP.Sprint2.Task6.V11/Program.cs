//Написать программу, которая использует сокращенную форму записи оператора switch вычисляет требуемое значение и возвращает результат.

//Условие: Дата некоторого дня характеризуется тремя натуральными числами: g(год), m(порядковый номер месяца) и n(число). По заданным g, n и m определить дату следующего дня. Заданный год не является високосным.

//Название проектов (консольного приложения, библиотеки классов, тестового модуля) оформить по шаблону в соответствии с вариантом. Интерфейс консольного приложения оформить по шаблону. 

using Tyuiu.GilevaAP.Sprint2.Task6.V11.Lib;
namespace Tyuiu.GilevaAP.Sprint2.Task6.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");


            Console.WriteLine("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите номер месяца: ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите год: ");
            int g = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.FindDateOfNextDay(g, n, m);
            Console.WriteLine($"Дата следующего дня: {res}");
            Console.ReadKey();
        }
    }
}
