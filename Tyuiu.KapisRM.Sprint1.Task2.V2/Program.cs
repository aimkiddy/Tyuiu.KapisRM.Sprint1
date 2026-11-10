using Tyuiu.KapisRM.Sprint1.Task2.V2.Lib;

namespace Tyuiu.KapisRM.Sprint1.Task2.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Капис Р. М. | СМАРТб-26-1";

            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                                  *");
            Console.WriteLine("* Тема: Выполнения варианта №2                                                                               *");
            Console.WriteLine("* Задание #2                                                                                                 *");
            Console.WriteLine("* Вариант #2                                                                                                 *");
            Console.WriteLine("* Выполнил: Капис Роман Максимович | СМАРТб-26-1                                                             *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                   *");
            Console.WriteLine("* Известен угол в градусах. Перевести угол в радианы.                                                        *");
            Console.WriteLine("* Ответ округлите до 3 знаков после запятой. Используйте Math.Round(res, 3).                                   *");
            Console.WriteLine("*                                                                                                            *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                           *");
            Console.WriteLine("**************************************************************************************************************");

            int alpha; 

            Console.WriteLine("Введите угол в градусах:");
            alpha = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                 *");
            Console.WriteLine("**************************************************************************************************************");

            double res = ds.ConvertAngleToRad(alpha);

            Console.WriteLine("Угол в радианах = " + res);
        }
    }
}