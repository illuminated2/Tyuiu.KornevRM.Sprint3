using Tyuiu.KornevRM.Sprint3.Task4.V14.Lib;
namespace Tyuiu.KornevRM.Sprint3.Task4.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;

            double res = ds.Calculate(startValue, stopValue);
            double wait = 0;
            Assert.AreEqual(wait, res);

        }
    }
}