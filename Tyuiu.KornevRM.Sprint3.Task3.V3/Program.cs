using Tyuiu.KornevRM.Sprint3.Task3.V3.Lib;
namespace Tyuiu.KornevRM.Sprint3.Task3.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           DataService ds = new DataService();
            Console.Title = "Спринт #3 | Выполнил: Корнев Р. М. | ИСПб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Алгоритмы циклической структуры                                   *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнил: Корнев Р. М. | ИСПб-24-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach заменить буквы                                   *");
            Console.WriteLine("* g  на * в строке: cvbmzff orffgtrr dkfvfffdr                            *");
            Console.WriteLine("*                                                                         *");
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
