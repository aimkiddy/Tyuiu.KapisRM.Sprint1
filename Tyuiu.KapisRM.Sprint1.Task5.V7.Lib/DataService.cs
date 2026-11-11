using System;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.KapisRM.Sprint1.Task5.V7.Lib
{
    public class DataService : ISprint1Task5V7
    {
        public int AngleToHoursMinutes(double f)
        {
            
            int hours = (int)(f / 30.0);
            return hours;
        }
    }
}