using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MoskalevSO.Sprint3.Task4.V7.Lib;

namespace Tyuiu.MoskalevSO.Sprint3.Task4.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            double res = ds.Calculate(-5, 5);

            double wait = 1;
            for (int x = -5; x <= -1; x++)
            {
                wait *= x / Math.Cos(x) + 1.5;
            }
            wait = Math.Round(wait, 3);

            Assert.AreEqual(wait, res);
        }
    }
}