using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KapisRM.Sprint1.Task3.V6.Lib
{
    public class DataService
    {
        public double Calculate(double distance, double consumption, double price)
        {
            double totalDistance = distance * 2;
            double totalFuel = (totalDistance / 100) * consumption;
            double cost = totalFuel * price;
            return Math.Round(cost, 3);
        }
    }
}