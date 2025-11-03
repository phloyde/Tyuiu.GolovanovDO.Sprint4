using Tyuiu.GolovanovDO.Sprint4.Task5.V2.Lib;
namespace Tyuiu.GolovanovDO.Sprint4.Task5.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] mas = { { 2, 4, 3, -1, 0},
                           {-4, -5, -1, 2, 1 },
                           { 4, 3, -2, -3, 4},
                           { 2, 3, -4, -2, 1 },
                           { 4, -2, -5, -1, 5} };

            int res = ds.Calculate(mas);
            int wait = 11;
            Assert.AreEqual(wait, res);


        }
    }
}
