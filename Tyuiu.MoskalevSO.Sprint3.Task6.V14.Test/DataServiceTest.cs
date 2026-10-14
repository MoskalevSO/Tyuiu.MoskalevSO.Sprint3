using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MoskalevSO.Sprint3.Task6.V14.Lib;

namespace Tyuiu.MoskalevSO.Sprint3.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int res = ds.GetSumTheDivisors(7, 16);
            int wait = 13;

            Assert.AreEqual(wait, res);
        }
    }
}