using System;
using Tyuiu.KapisRM.Sprint1.Task7.V14.Lib;

namespace Tyuiu.KapisRM.Sprint1.Task7.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Капис Р. М. | СМАРТб-26-1";

            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                                   *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                                                     *");
            Console.WriteLine("* Задание #7                                                                                                  *");
            Console.WriteLine("* Вариант #14                                                                                                 *");
            Console.WriteLine("* Выполнил: Капис Роман Максимович | СМАРТб-26-1                                                              *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                  *");
            Console.WriteLine("* Написать программу, которая вычисляет математическое выражение по исходным значениям данных,                 *");
            Console.WriteLine("* вводимых пользователем. Ответ округлите до 3 знаков после запятой.                                          *");
            Console.WriteLine("* z = 2^(-x) + (5*x^2)/(3*x^3) - cos(x^2) + sin(2xy)                                                          *");
            Console.WriteLine("*                                                                                                             *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                            *");
            Console.WriteLine("**************************************************************************************************************");

            double a, b, c;

            Console.Write("Введите значение X (a): ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение Y (b): ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение третьего параметра (c): ");
            c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                  *");
            Console.WriteLine("**************************************************************************************************************");

            double res = ds.Calculate(a, b, c);

            Console.WriteLine($"Результат вычисления по формуле = {res}");

            Console.ReadKey();
        }
    }
}