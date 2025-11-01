using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.RadchenkoAV.Sprint3.Task5.V23.Lib
{
    public class DataService : ISprint3Task5V23
    {
        public double GetSumSumSeries(int t, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double sumSeries = 0;
            int t, k;
            for (t = startValue1; t <= stopValue1; t++)
            {
                for (k = startValue2; k <= stopValue2; k++)
                {
                    sumSeries = sumSeries + (Math.Pow(t / Math.Cos(k), j));
                }
            }
            return Math.Round(sumSeries, 3);
        }
    }
}
