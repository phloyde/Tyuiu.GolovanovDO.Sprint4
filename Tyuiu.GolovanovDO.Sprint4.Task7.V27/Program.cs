using Tyuiu.GolovanovDO.Sprint4.Task7.V27.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        int rows = 4;
        int cols = 3;
        int[,] mtrx = new int[rows, cols];
        string str = "583197256891";
        int res = ds.Calculate(rows, cols, str);

        Console.WriteLine("Результат: " + res);
        Console.ReadKey();
    }
}