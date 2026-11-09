using System;
using Tyuiu.KapisRM.Sprint1.Task1.V10.Lib;

namespace Tyuiu.KapisRM.Sprint1.Task1.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #0 | Выполнил: Капис Р. М. | СМАРТб-26-1";
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                                   *");
            Console.WriteLine("* Тема: Написание решения для варианта №10                                                                    *");
            Console.WriteLine("* Задание #1                                                                                                  *");
            Console.WriteLine("* Вариант #10                                                                                                 *");
            Console.WriteLine("* Выполнил: Капис Роман Максимович | СМАРТб-26-1                                                              *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                    *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,                                     *");
            Console.WriteLine("* вычисляет результат по формуле (x+y)/(1+x) и печатает его на экране.                                        *");
            Console.WriteLine("*                                                                                                             *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                            *");
            Console.WriteLine("**************************************************************************************************************");

            Console.Write("Введите значение переменной X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите значение переменной Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                  *");
            Console.WriteLine("**************************************************************************************************************");

            try
            {
                DataService ds = new DataService();
                double res = ds.Calculate(x, y);
                Console.WriteLine($"Результат вычисления по формуле (x + y) / (1 + x) равен: {res:F3}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}