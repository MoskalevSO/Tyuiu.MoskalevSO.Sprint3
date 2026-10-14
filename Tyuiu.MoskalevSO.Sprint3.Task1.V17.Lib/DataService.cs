using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MoskalevSO.Sprint3.Task1.V17.Lib
{
    public class DataService : ISprint3Task1V17
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double p = 1;
            int k = startValue;
            while (k <= stopValue)
            {
                p *= Math.Pow(2 / Math.Cos(value), k);
                k++;
            }
            return Math.Round(p, 3);
        }
    }
}