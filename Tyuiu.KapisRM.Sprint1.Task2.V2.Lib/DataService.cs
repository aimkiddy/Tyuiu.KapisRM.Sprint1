using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.KapisRM.Sprint1.Task2.V2.Lib
{
    public class DataService : ISprint1Task2V2
    {  
      public double ConvertAngleToRad(int value)
        {
            return Math.Round((value * Math.PI) / 180, 3);
        }
    }
}