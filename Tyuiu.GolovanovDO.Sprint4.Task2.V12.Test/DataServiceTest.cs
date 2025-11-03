using Tyuiu.GolovanovDO.Sprint4.Task2.V12.Lib;
namespace Tyuiu.GolovanovDO.Sprint4.Task2.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = { 5, 4, 5, 6, 5, 8, 9, 6, 7, 7, 4, 6, 5, 8 };
            int res = ds.Calculate(array);
            int wait = 43;
            Assert.AreEqual(wait, res);
        }
    }
}
