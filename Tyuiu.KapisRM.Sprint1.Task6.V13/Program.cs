
using System;
using Tyuiu.KapisRM.Sprint1.Task6.V13.Lib;

namespace tyuiu.sprint1.task6.v13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Капис Р. М. | СМАРТб-26-1";

            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                                   *");
            Console.WriteLine("* Тема: Работа со строками класс String                                                                       *");
            Console.WriteLine("* Задание #6                                                                                                  *");
            Console.WriteLine("* Вариант #13                                                                                                 *");
            Console.WriteLine("* Выполнил: Капис Роман Максимович | СМАРТб-26-1                                                              *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                  *");
            Console.WriteLine("* Написать программу: пользователь вводит текст. Проверить, что буквы строки упорядочены по алфавиту.         *");
            Console.WriteLine("*                                                                                                             *");
            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                            *");
            Console.WriteLine("**************************************************************************************************************");

            Console.Write("Введите строку: ");
            string content = Console.ReadLine();

            Console.WriteLine("**************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                  *");
            Console.WriteLine("**************************************************************************************************************");

            
            bool res = ds.CheckWordsAlphabet(content);

            if (res)
            {
                Console.WriteLine("Буквы в строке упорядочены по алфавиту.");
            }
            else
            {
                Console.WriteLine("Буквы в строке НЕ упорядочены по алфавиту.");
            }

            Console.ReadKey();
        }
    }
}