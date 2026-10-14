using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MoskalevSO.Sprint3.Task1.V17.Lib;

namespace Tyuiu.MoskalevSO.Sprint3.Task1.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            double res = ds.GetMultiplySeries(1, 1, 4);
            double wait = Math.Round(Math.Pow(2 / Math.Cos(1), 10), 3);

            Assert.AreEqual(wait, res);
        }
    }
}