using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MoskalevSO.Sprint3.Task7.V14.Lib;

namespace Tyuiu.MoskalevSO.Sprint3.Task7.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            double[] res = ds.GetMassFunction(-5, 5);
            double[] wait = { -19.62, -17.12, -18.15, -63.13, -24.92, -5, -1.46, 1.57, 6.38, 32.78, 225.11 };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}