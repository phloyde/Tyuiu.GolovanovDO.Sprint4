using Tyuiu.GolovanovDO.Sprint4.Task6.V27.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        var mass = new string[] { "Квадрат", "Прямоугольник", "Круг", "Треугольник", "Пятиугольник", "Шестиугольник", "Восьмиугольник" };
        int res = ds.Calculate(mass);

        Console.WriteLine(res);
    }
}