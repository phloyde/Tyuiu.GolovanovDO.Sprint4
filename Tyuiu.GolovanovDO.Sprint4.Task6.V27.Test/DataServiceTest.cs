using Tyuiu.GolovanovDO.Sprint4.Task6.V27.Lib;
namespace Tyuiu.GolovanovDO.Sprint4.Task6.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            var mass = new string[] { "Квадрат", "Прямоугольник", "Круг", "Треугольник", "Пятиугольник", "Шестиугольник", "Восьмиугольник" };
            int res = ds.Calculate(mass);
            int wait = 1;
            Assert.AreEqual(wait, res);
        }
    }
}
