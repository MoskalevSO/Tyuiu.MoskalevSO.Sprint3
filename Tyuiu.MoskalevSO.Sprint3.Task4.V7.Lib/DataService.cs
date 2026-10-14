using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MoskalevSO.Sprint3.Task4.V7.Lib
{
    public class DataService : ISprint3Task4V7
    {
        public double Calculate(int startValue, int stopValue)
        {
            double result = 1;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    break;
                }
                double y = x / Math.Cos(x) + 1.5;
                result *= y;
            }
            return Math.Round(result, 3);
        }
    }
}