using Tyuiu.KornevRM.Sprint3.Task3.V3.Lib;
namespace Tyuiu.KornevRM.Sprint3.Task3.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string value = "cvbmzff orffgtrr dkfvfffdr";
            char item = 'f';
            Console.WriteLine("строка: " + value);
            Console.WriteLine("символ: " + item);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Количество символов = "+ ds.GetMinCharCount(value,item));
            Console.ReadKey();
        }
    }
}
