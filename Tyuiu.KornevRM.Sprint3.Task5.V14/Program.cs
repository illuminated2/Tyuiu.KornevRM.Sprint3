using Tyuiu.KornevRM.Sprint3.Task5.V14.Lib;
namespace Tyuiu.KornevRM.Sprint3.Task5.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int x = 5;
            int startValue1 = 1;
            int startValue2 = 1;
            int stopValue1 = 3;
            int stopValue2 = 14;
            Console.WriteLine("Переменная Х = " + x);
            Console.WriteLine("Старт 1 шага = " + startValue1);
            Console.WriteLine("Конец 1 шага = " + stopValue2); 
            Console.WriteLine("Старт 2 шага = " + startValue1);
            Console.WriteLine("Конец 2 шага = " + stopValue2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.GetSumSumSeries(x,startValue1,startValue2,stopValue1,stopValue2));
            Console.ReadKey();

        }
    }
}
