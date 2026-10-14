using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MoskalevSO.Sprint3.Task5.V8.Lib;

namespace Tyuiu.MoskalevSO.Sprint3.Task5.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumSumSeries()
        {
            DataService ds = new DataService();

            double res = ds.GetSumSumSeries(1, 1, 3, 12);
            double wait = 119.066;

            Assert.AreEqual(wait, res);
        }
    }
}