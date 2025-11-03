using Tyuiu.GolovanovDO.Sprint4.Task3.V21.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        int[,] mass = { { 8, 3, 3, 3, 5},
                            {6, 7, 3, 3, 7},
                            {4, 5, 4, 6, 6},
                            {5, 5, 8, 8, 7},
                            {4, 6, 6, 7, 7} };

        int res = ds.Calculate(mass);
        Console.WriteLine(res);
        Console.ReadKey();
    }
}