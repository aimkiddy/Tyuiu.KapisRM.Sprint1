using System;
using Tyuiu.KapisRM.Sprint1.Task4.V27.Lib;

namespace Tyuiu.KapisRM.Sprint1.Task4.V27.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Капис Р. М. | СМАРТб-26-1";

            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                                   *");
            Console.WriteLine("* Тема: Class Math                                                                          *");
            Console.WriteLine("* Задание #4                                                                                                  *");
            Console.WriteLine("* Вариант #27                                                                                                 *");
            Console.WriteLine("* Выполнил: Капис Роман Максимович | СМАРТб-26-1                                                              *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                  *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, вычисляет результат по формуле        *");
            Console.WriteLine("* и печатает его на экране. Ответ округлите до 3 знаков после запятой.                                        *");
            Console.WriteLine("* Формула: (1 + sin(pi * x)) / (x - sqrt(abs(y)))                                                             *");
            Console.WriteLine("*                                                                                                             *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                            *");
            Console.WriteLine("**************************************************************************************************************");

            double x, y;

            Console.Write("Введите значение X: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение Y: ");
            y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                  *");
            Console.WriteLine("**************************************************************************************************************");

            double res = ds.Calculate(x, y);

            Console.WriteLine($"Результат вычисления по формуле = {res}");

            Console.ReadKey();
        }
    }
}