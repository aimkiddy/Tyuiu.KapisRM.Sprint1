using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KapisRM.Sprint1.Task4.V27.Lib
{
    public class DataService : ISprint1Task4V27
    {
        public double Calculate(double x, double y)
        {
            // Формула: (1 + sin(pi * x)) / (x - sqrt(abs(y)))
            double res = (1 + Math.Sin(Math.PI * x)) / (x - Math.Sqrt(Math.Abs(y)));
            return Math.Round(res, 3);
        }
    }
}