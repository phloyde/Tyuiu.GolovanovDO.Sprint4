using Tyuiu.GolovanovDO.Sprint4.Task7.V27.Lib;
namespace Tyuiu.GolovanovDO.Sprint4.Task7.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int rows = 4;
            int cols = 3;
            int[,] mtrx = new int[rows, cols];
            string str = "583197256891";
            int res = ds.Calculate(rows, cols, str);
            Assert.AreEqual(4, res);
        }
    }
}
