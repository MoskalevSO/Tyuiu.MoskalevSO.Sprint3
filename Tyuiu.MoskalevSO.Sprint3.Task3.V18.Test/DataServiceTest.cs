using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MoskalevSO.Sprint3.Task3.V18.Lib;

namespace Tyuiu.MoskalevSO.Sprint3.Task3.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidReplaceNumOnChar()
        {
            DataService ds = new DataService();

            string res = ds.ReplaceNumOnChar("4n5nvf 56 bgy", 'n');
            string wait = "nnnnvf nn bgy";

            Assert.AreEqual(wait, res);
        }
    }
}