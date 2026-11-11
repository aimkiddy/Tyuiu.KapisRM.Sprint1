using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KapisRM.Sprint1.Task3.V6.Lib
{
    public class DataService : ISprint1Task3V6
    {
        public double TravelCost(double distance, double gasFlow, double gasPrice)
        {
            double totalDistance = distance * 2;
            double totalFuel = (totalDistance / 100) * gasFlow;
            double cost = totalFuel * gasPrice;
            return Math.Round(cost, 3);
        }
    }
}