using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KapisRM.Sprint1.Task0.V18.Lib;

namespace Tyuiu.KapisRM.Sprint1.Task0.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнил: Капис Р. М. | СМАРТб-26-1";

            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                                   *");
            Console.WriteLine("* Тема: Выполнения варианта №18                                                                               *");
            Console.WriteLine("* Задание #0                                                                                                 *");
            Console.WriteLine("* Вариант #18                                                                                                *");
            Console.WriteLine("* Выполнил: Капис Роман Максимович | СМАРТб-26-1                                                             *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                   *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение 9*(6/2*3)/9/3 и печатает результат на экране.               *");
            Console.WriteLine("*                                                                                                            *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                           *");
            Console.WriteLine("**************************************************************************************************************");

            DataService ds = new DataService();


            int[] nums1 = new int[] { 9, 6, 2, 3, 9, 3 };
            int[] nums2 = new int[] { 9, 6, 2, 3, 9, 3 };

            Console.WriteLine("Значение выражения = 9 * (6 / 2 * 3) / 9 / 3");

            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                 *");
            Console.WriteLine("**************************************************************************************************************");

            double res = ds.Calculate();
            Console.WriteLine("Результат вычисления равен: " + res);

            Console.ReadKey();
        }
    }
}

        

