using Tyuiu.KornevRM.Sprint3.Task6.V17.Lib;
namespace Tyuiu.KornevRM.Sprint3.Task6.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int startValue = 10;
            int stopValue = 20;
            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 0;
            Assert.AreEqual(wait, res);
        }
    }
}