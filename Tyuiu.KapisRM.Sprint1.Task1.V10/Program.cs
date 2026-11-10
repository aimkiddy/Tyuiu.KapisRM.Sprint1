using Tyuiu.KapisRM.Sprint1.Task1.V10.Lib;

namespace Tyuiu.KapisRM.Sprint1.Task1.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Капис Р. М. | СМАРТб-26-1";

            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                                  *");
            Console.WriteLine("* Тема: Выполнения варианта №10                                                                              *");
            Console.WriteLine("* Задание #1                                                                                                *");
            Console.WriteLine("* Вариант #10                                                                                                *");
            Console.WriteLine("* Выполнил: Капис Роман Максимович | СМАРТб-26-1                                                             *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                   *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,                                      *");
            Console.WriteLine("* вычисляет результат по формуле (x+y)/(1+x) и печатает его на экране.                                       *");
            Console.WriteLine("*                                                                                                            *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                           *");
            Console.WriteLine("**************************************************************************************************************");

            double x, y;

            Console.WriteLine("Введите значение x:");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение y:");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                 *");
            Console.WriteLine("**************************************************************************************************************");

            double res = ds.Calculate(x, y);

            Console.WriteLine("Результат вычисления выражения (x + y) / (1 + x) = " + Math.Round(res, 3));

            Console.ReadKey();
        }
    }
}
