using Tyuiu.KornevRM.Sprint3.Task5.V14.Lib;
namespace Tyuiu.KornevRM.Sprint3.Task5.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startvalue2 = 1;
            int stopValue2 = 14;

            double res = ds.GetSumSumSeries(x, startValue1, startvalue2, stopValue1, stopValue2);

            double wait = -31.275;

            Assert.AreEqual(wait, res);
           
        }
    }
}