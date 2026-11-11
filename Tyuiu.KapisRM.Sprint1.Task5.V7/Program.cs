using System;
using Tyuiu.KapisRM.Sprint1.Task5.V7.Lib;

namespace Tyuiu.KapisRM.Sprint1.Task5.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Капис Р. М. | СМАРТб-26-1";

            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                                   *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                                                                       *");
            Console.WriteLine("* Задание #5                                                                                                  *");
            Console.WriteLine("* Вариант #7                                                                                                  *");
            Console.WriteLine("* Выполнил: Капис Роман Максимович | СМАРТб-26-1                                                              *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                  *");
            Console.WriteLine("* Определить h – полное количество часов прошедших от начала суток до того момента (в первой половине дня),     *");
            Console.WriteLine("* когда часовая стрелка повернулась на f градусов (0 < f < 360, f – вещественное число).                       *");
            Console.WriteLine("*                                                                                                             *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                            *");
            Console.WriteLine("**************************************************************************************************************");

            double f;

            Console.Write("Введите угол поворота часовой стрелки (градусы) -> ");
            f = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                  *");
            Console.WriteLine("**************************************************************************************************************");

          
            int res = ds.AngleToHoursMinutes(f);

            Console.WriteLine($"Количество часов от начала суток: {res}");

            Console.ReadKey();
        }
    }
}