using System;
using Tyuiu.KapisRM.Sprint1.Task3.V6.Lib;

namespace Tyuiu.KapisRM.Sprint1.Task3.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Капис Р. М. | СМАРТб-26-1";

            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                                   *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                                                      *");
            Console.WriteLine("* Задание #3                                                                                                  *");
            Console.WriteLine("* Вариант #6                                                                                                  *");
            Console.WriteLine("* Выполнил: Капис Роман Максимович | СМАРТб-26-1                                                              *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                  *");
            Console.WriteLine("* Написать программу вычисления стоимости поездки на автомобиле на дачу (туда и обратно).                     *");
            Console.WriteLine("* Исходными данными являются: расстояние до дачи (км); количество бензина, которое потребляет                  *");
            Console.WriteLine("* автомобиль на 100 км пробега; цена одного литра бензина. Ответ округлите до 3 знаков после запятой.       *");
            Console.WriteLine("*                                                                                                             *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                            *");
            Console.WriteLine("**************************************************************************************************************");

            double distance, consumption, price;

            Console.Write("Расстояние до дачи (км) -> ");
            distance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Расход бензина (литров на 100 км пробега) -> ");
            consumption = Convert.ToDouble(Console.ReadLine());

            Console.Write("Цена литра бензина (руб.) -> ");
            price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                  *");
            Console.WriteLine("**************************************************************************************************************");

            double res = ds.Calculate(distance, consumption, price);

            Console.WriteLine($"Поездка на дачу и обратно обойдется в {res} руб.");

            Console.ReadKey();
        }
    }
}