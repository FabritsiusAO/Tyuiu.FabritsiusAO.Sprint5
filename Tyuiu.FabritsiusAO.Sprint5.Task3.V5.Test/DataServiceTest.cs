using Tyuiu.FabritsiusAO.Sprint5.Task3.V5.Lib;
namespace Tyuiu.FabritsiusAO.Sprint5.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedCalculateValid()
        {
            DataService ds = new();
            int x = 2;
            double res = ds.Calculate(x);
            double wait = 13;
            Assert.AreEqual(wait, res);
        }
    }
}