using Tyuiu.KornevRM.Sprint3.Task6.V17.Lib;
namespace Tyuiu.KornevRM.Sprint3.Task6.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int startValue = 10;
            int stopValue = 20;
            Console.WriteLine("начало отрезка: " + startValue);
            Console.WriteLine("конец отрезка: " + stopValue);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.GetSumTheDivisors(startValue, stopValue));
            Console.ReadKey();
        }
    }
}
