using Tyuiu.KornevRM.Sprint3.Task3.V3.Lib;
namespace Tyuiu.KornevRM.Sprint3.Task3.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string value = "cvbmzff orffgtrr dkfvfffdr";
            char item = 'f';
            int res = ds.GetMinCharCount(value,item);
            int wait = 2;
            Assert.AreEqual(wait,res);



        }
    }
}