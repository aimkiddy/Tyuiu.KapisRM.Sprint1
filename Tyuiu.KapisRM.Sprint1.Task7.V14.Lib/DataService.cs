using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KapisRM.Sprint1.Task7.V14.Lib
{
    public class DataService : ISprint1Task1V14
    {
        public double Calculate(double a, double b, double c)
        {
            double res = Math.Pow(2, -a) + (5 * Math.Pow(a, 2)) / (3 * Math.Pow(a, 3)) - Math.Cos(Math.Pow(a, 2)) + Math.Sin(2 * a * b);
            return Math.Round(res, 3);
        }
    }
}