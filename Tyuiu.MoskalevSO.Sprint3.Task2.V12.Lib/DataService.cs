using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MoskalevSO.Sprint3.Task2.V12.Lib
{
    public class DataService : ISprint3Task2V12
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double p = 1;
            int i = startValue;
            do
            {
                p *= Math.Pow(300 / (i + Math.Pow(value, i)), i);
                i++;
            }
            while (i <= stopValue);
            return Math.Round(p, 3);
        }
    }
}