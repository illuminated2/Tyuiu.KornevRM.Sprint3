using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.KornevRM.Sprint3.Task5.V14.Lib
{
    public class DataService : ISprint3Task5V14
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double count = 0;
            for (int i = startValue1; i <= stopValue1; i++)
            {
                for (int j = startValue2; j <= stopValue2; j++)
                {
                    count += (Math.Sin(x) + (2 / startValue2));

                }
            }
            return Math.Round(count, 3);
        }
    }
}
