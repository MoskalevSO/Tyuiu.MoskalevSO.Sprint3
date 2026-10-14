using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MoskalevSO.Sprint3.Task2.V12.Lib;

namespace Tyuiu.MoskalevSO.Sprint3.Task2.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            double res = ds.GetMultiplySeries(5, 1, 5);

            double wait = 1;
            for (int i = 1; i <= 5; i++)
            {
                wait *= Math.Pow(300 / (i + Math.Pow(5, i)), i);
            }
            wait = Math.Round(wait, 3);

            Assert.AreEqual(wait, res);
        }
    }
}